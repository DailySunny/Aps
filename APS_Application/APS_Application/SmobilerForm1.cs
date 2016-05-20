using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace APS_Application
{
    partial class LoginForm : Smobiler.Core.MobileForm
    {

        private void SmobilerForm1_Load(object sender, EventArgs e)
        {

        }
        private void switch1_CheckChanged(object sender, CheckEventArgs e)
        {
            if(switch1.Checked){
            MessageBox.Show("请联系管理员进行重置！");
            switch1.Checked = false;
            }
        }
        private StringBuilder querystring;
        private static SqlDataReader reader;
        public static string role;
        public static int role_id;
        public static string username;
        private void login_CheckChanged(object sender, CheckEventArgs e)
        {
           // LoginForm f1 = new LoginForm();
            username = login_name.Text;
            string passwd = login_pwd.Text;
            if (username.Trim() == string.Empty || passwd.Trim() == string.Empty)//判断用户名和密码不为空
            {
                MessageBox.Show("登录名或密码不能为空！");
                login.Checked = false;
            }
            else
            {
                //SqlHelper helper = new SqlHelper();
                querystring = new StringBuilder();
                querystring.AppendFormat("select * from [vwpt_logistic].[dbo].[User] where Login_ID='{0}' and Passwd='{1}'", username, passwd);
                reader =SqlHelper.login(querystring.ToString());
                //判断reader是否有值
                try
                {
                    if (reader.Read())
                    {
                        role = reader["Role"].ToString();
                        role_id = Convert.ToInt32(reader["Role_id"]);
                        login.Checked = false;
                        MenuForm menuform = new MenuForm();
                        Redirect(menuform);
                    }
                    else
                    {
                        MessageBox.Show("登录名或密码错误！");
                        login.Checked = false;
                    }
                    //string Sqlusername = reader["Login_ID"].ToString();
                    //string Sqlpasswd = reader["Passwd"].ToString();
                }
                catch (Exception e1)
                {
                    Console.WriteLine("reader有错");
                    MessageBox.Show("数据库出错啦！");
                }
            }
        }

    }
    }
