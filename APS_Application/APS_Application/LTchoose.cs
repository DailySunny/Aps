using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace APS_Application
{
    partial class LTchoose : Smobiler.Core.MobileForm
    {
        public static String changqu;

        private void LTchoose_Load(object sender, EventArgs e)
        {
            
        }
        public void jump_click()
        {
            Select se = new Select();
            Redirect(se);
        }


        private void button14_Click(object sender, EventArgs e)
        {
            changqu = button14.Text;
            jump_click();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            changqu = button13.Text;
            jump_click();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            changqu = button12.Text;
            jump_click();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            changqu = button11.Text;
            jump_click();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            changqu = button10.Text;
            jump_click();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            changqu = button9.Text;
            jump_click();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            changqu = button8.Text;
            jump_click();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            changqu = button17.Text;
            jump_click();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            changqu = button6.Text;
            jump_click();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changqu = button5.Text;
            jump_click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changqu = button3.Text;
            jump_click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changqu = button4.Text;
            jump_click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changqu = button2.Text;
            jump_click();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            changqu = button7.Text;
            jump_click();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            changqu = button19.Text;
            jump_click();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            changqu = button18.Text;
            jump_click();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            MenuForm me = new MenuForm();
            Redirect(me);
        }

   
    }
}