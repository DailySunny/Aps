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
            MessageBox.Show("����ϵ����Ա�������ã�");
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
            if (username.Trim() == string.Empty || passwd.Trim() == string.Empty)//�ж��û��������벻Ϊ��
            {
                MessageBox.Show("��¼�������벻��Ϊ�գ�");
                login.Checked = false;
            }
            else
            {
                //SqlHelper helper = new SqlHelper();
                querystring = new StringBuilder();
                querystring.AppendFormat("select * from [vwpt_logistic].[dbo].[User] where Login_ID='{0}' and Passwd='{1}'", username, passwd);
                reader =SqlHelper.login(querystring.ToString());
                //�ж�reader�Ƿ���ֵ
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
                        MessageBox.Show("��¼�����������");
                        login.Checked = false;
                    }
                    //string Sqlusername = reader["Login_ID"].ToString();
                    //string Sqlpasswd = reader["Passwd"].ToString();
                }
                catch (Exception e1)
                {
                    Console.WriteLine("reader�д�");
                    MessageBox.Show("���ݿ��������");
                }
            }
        }

    }
    }
