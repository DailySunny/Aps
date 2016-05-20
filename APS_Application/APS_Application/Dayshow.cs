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
    partial class Dayshow : Smobiler.Core.MobileForm
    {
        public static StringBuilder querystreing;
        public static string line;
        public static DateTime _date;
        private int btn;
        private void Dayshow_Load(object sender, EventArgs e)
        {
            line = Select.cq;
            _date = Select._date;
            label1.Text = line+"     "+_date.ToShortDateString();
            Console.WriteLine("line:{0},_date:{1}",line,_date);
            datashow(line, _date.ToShortDateString());

        }
        public void datashow(string line,string _date){
            querystreing = new StringBuilder();
            querystreing.AppendFormat("select [Part_No],[Part_Name],[Plan_Date],[Plan_Sequence],[Demand],[Plan_QTY],[Plan_Stock],[Bankin] from [vwpt_logistic].[dbo].[ProductionPlan] where Plan_Line='{0}' and state=1 and Plan_Date='{1}'", line, _date);
            DataTable dtable = SqlHelper.getDataShow(querystreing.ToString());
            Console.WriteLine("标的行数" + dtable.Rows.Count);
            gridView1.DataSource = dtable;
            gridView1.DataBind();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Select s = new Select();
            Redirect(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            line = Select.cq;
            _date = _date.AddDays(-1);
            label1.Text = line + "     " + _date.ToShortDateString();
            Console.WriteLine("前一天："+_date.ToShortDateString());
            datashow(line,_date.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            line = Select.cq;
            _date = _date.AddDays(1);
            label1.Text = line + "     " + _date.ToShortDateString();
            Console.WriteLine("厚一天:"+_date);
            datashow(line, _date.ToShortDateString());
        }
    }
}