using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.Data.SqlClient;

namespace APS_Application
{
    partial class partdetail : Smobiler.Core.MobileForm
    {
        public static string part_no;
        public static int week1;
        public static int week2;
        public static int week3;
        public static int year1;
        public static int year2;
        public static string line;
        public static int weektotal;
        private StringBuilder querystring;
        private void partdetaillayout_Load(object sender, EventArgs e)
        {
            part_no = partselect.part_no;
            label1.Text = part_no;
            label2.Text = partselect.part_name;
            querystring=new StringBuilder();
            line=Select.cq;
            //判断三个礼拜，首先获取当前周是第几周，然后判断下一周是否超过最后一周，再判断下一周是否超过最后一周
            HelpDAO.getYearandWeek();
            week1=HelpDAO.week_now;
            weektotal=HelpDAO.week_last;
            Console.WriteLine("weeknow:"+week1+"   weektotal:"+weektotal);
            if(week1<weektotal){
                week2=week1+1;
                year1=DateTime.Now.Year;
                if(week2<weektotal){
                    week3=week2+1;
                    year1=DateTime.Now.Year;
                    querystring.AppendFormat("select [Plan_Line],Convert(varchar(12),[Plan_Date],3)as [Plan_Date],[Plan_Week],[Plan_QTY],CONVERT(varchar(20),[Demand]) + CHAR(10)+CHAR(13)+CONVERT(varchar(20),[Demand_Amout])as Demand,[Plan_Stock],[Bankin] from [vwpt_logistic].[dbo].[ProductionPlan] " +
"where Part_No='{0}' and Plan_Line='{1}' and Plan_Week in ({2},{3},{4}) and Plan_Year={5} order by Plan_Line,Plan_Date",part_no,line,week1,week2,week3,year1);
                    Console.WriteLine("querystring:"+querystring);
                }else{
                    week3=1;
                    year1 = DateTime.Now.Year;
                    year2 = year1 + 1;//前两周在一年，第三周在下一年
                    querystring.AppendFormat("select [Plan_Line],Convert(varchar(12),[Plan_Date],3)as [Plan_Date],[Plan_Week],[Plan_QTY],CONVERT(varchar(20),[Demand]) + CHAR(10)+CHAR(13)+CONVERT(varchar(20),[Demand_Amout])as Demand,[Plan_Stock],[Bankin] from [vwpt_logistic].[dbo].[ProductionPlan] " +
"where Part_No='{0}' and Plan_Line='{1}' and (Plan_Week in ({2},{3}) and Plan_Year={4}) or (Plan_Week={5} and Plan_Year={6})order by Plan_Line,Plan_Date", part_no, line, week1, week2,year1,week3,year2);
                }
            }
            else
            {
                week2 = 1;
                week3 = 2;
                year1 = DateTime.Now.Year;
                year2 = year1 = 1;
                querystring.AppendFormat("select [Plan_Line],Convert(varchar(12),[Plan_Date],3)as [Plan_Date],[Plan_Week],[Plan_QTY],CONVERT(varchar(20),[Demand]) + CHAR(10)+CHAR(13)+CONVERT(varchar(20),[Demand_Amout])as Demand,[Plan_Stock],[Bankin] from [vwpt_logistic].[dbo].[ProductionPlan] " +
"where Part_No='{0}' and Plan_Line='{1}' and Plan_Week={2} and Plan_Year={3}) or (Plan_Week in ({4},{5}) and Plan_Year={6}) order by Plan_Line,Plan_Date", part_no, line, week1,year1,week2,week3,year2);
            }
            DataTable dtable = SqlHelper.getDataShow(querystring.ToString());
            Console.WriteLine("line     行数："+dtable.Rows.Count);
            this.gridView1.DataSource = dtable;
            this.gridView1.DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            partselect pr = new partselect();
            Redirect(pr);
        }
    }
}