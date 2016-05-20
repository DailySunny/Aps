using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace APS_Application
{

    class SqlHelper
    {
        private static string connString = ConfigurationManager.AppSettings["sqlcon"];
        private static SqlConnection sqlcon= null;
        private static SqlCommand sqlcomd= null;
        //登录界面数据库方法
        public static SqlDataReader login(string querystring)
        {
            sqlcon = new SqlConnection(connString);
            sqlcomd = new SqlCommand(querystring, sqlcon);
            try
            {
                sqlcon.Open();
                Console.WriteLine("数据库连接成功");
                SqlDataReader reader = sqlcomd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
               throw ex;
            }
            
        }

        //查询记录
        public static DataTable getDataShow(string querystring){

            sqlcon = new SqlConnection(connString);
            sqlcomd = new SqlCommand(querystring,sqlcon);
            DataSet dataSet = new DataSet();
            try
            {
                sqlcon.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcomd);
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
