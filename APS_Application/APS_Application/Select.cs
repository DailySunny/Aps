using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace APS_Application
{
    partial class Select : Smobiler.Core.MobileForm
    {
        public static string cq;
        public static DateTime _date;
        private void button1_Click(object sender, EventArgs e)
        {
            partselect pt = new partselect();
            Redirect(pt);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _date = datePicker1.CurrentDate;
            Console.WriteLine("-----------------------data:" + _date);
            Dayshow dy = new Dayshow();
            Redirect(dy);
        }

        private void Select_Load(object sender, EventArgs e)
        {
            cq = LTchoose.changqu;
            label1.Text = cq;
        }

        private void datePicker1_DatePicked(object sender, DatePickerEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LTchoose me = new LTchoose();
            Redirect(me);
        }
    }
}