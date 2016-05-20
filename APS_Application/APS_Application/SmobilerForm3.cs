using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace APS_Application
{
    partial class MenuForm : Smobiler.Core.MobileForm
    {
        private void MenuForm_Load(object sender, EventArgs e)
        {
            LeftLayoutData.Items["username"].Text = LoginForm.username;
            LeftLayoutData.Items["label1"].Text = LoginForm.role;
            Console.WriteLine("identity" + LoginForm.role);
            int role_id = LoginForm.role_id;
            if (0 <= role_id && role_id < 40)
            {
                LeftLayoutData.Items["label2"].Text = "制造部";
            }
            else
            {
                LeftLayoutData.Items["label2"].Text = "规划与物流";
            }
        }

        private void nextweek_Click(object sender, EventArgs e)
        {
            LTchoose lt = new LTchoose();
            Redirect(lt);
        }

        private void thisweek_Click(object sender, EventArgs e)
        {
           // CurrentWeekPlan cu = new CurrentWeekPlan();
            //Redirect(cu);
        }

       
    }
}