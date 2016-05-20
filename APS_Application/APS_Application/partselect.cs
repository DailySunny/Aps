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
    partial class partselect : Smobiler.Core.MobileForm
    {
        public static string line;
        public static StringBuilder querystring;
        public static int week;
        private void partselect_Load(object sender, EventArgs e)
        {
            
            line = Select.cq;
            querystring = new StringBuilder();
            querystring.AppendFormat("select DISTINCT [Part_No],[Part_Name] from [vwpt_logistic].[dbo].[ProductionPlan] where Plan_Line='{0}'",line);
            SqlHelper.getDataShow(querystring.ToString());
            DataTable dtable = SqlHelper.getDataShow(querystring.ToString());
            Console.WriteLine("line有多少行"+dtable.Rows.Count);
            this.gridView1.DataSource = dtable;
            this.gridView1.DataBind();
        }
        public static string part_no;
        public static string part_name;
        private void gridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            part_no = e.Cell.Items["label1"].Value.ToString();
            part_name = e.Cell.Items["label2"].Value.ToString();
            partdetail pt = new partdetail();
            Redirect(pt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select se = new Select();
            Redirect(se);
        }
    }
}