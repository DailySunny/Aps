using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class Select : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public Select()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.datePicker1 = new Smobiler.Core.Controls.DatePicker();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.FontSize = 8F;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(120F, 15F);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new Smobiler.Core.PointS(1F, 49F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(42F, 12F);
            this.label2.TabIndex = 3;
            this.label2.Text = "按日期查询";
            // 
            // datePicker1
            // 
            this.datePicker1.BackColor = System.Drawing.Color.LimeGreen;
            this.datePicker1.Location = new Smobiler.Core.PointS(42F, 49F);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.SizeF(42F, 13F);
            this.datePicker1.TabIndex = 5;
            this.datePicker1.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.datePicker1_DatePicked);
            // 
            // label4
            // 
            this.label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label4.Location = new Smobiler.Core.PointS(0F, 82F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.SizeF(42F, 13F);
            this.label4.TabIndex = 6;
            this.label4.Text = "按零件查询";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.BorderRadius = 4;
            this.button1.Location = new Smobiler.Core.PointS(56F, 82F);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.SizeF(48F, 14F);
            this.button1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button1.TabIndex = 7;
            this.button1.Text = "确认查询";
            this.button1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.BorderRadius = 4;
            this.button2.Location = new Smobiler.Core.PointS(90F, 49F);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.SizeF(28F, 13F);
            this.button2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button2.TabIndex = 8;
            this.button2.Text = "确认查询";
            this.button2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.BackColorAlpha = 0;
            this.button3.FontSize = 8F;
            this.button3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.button3.Location = new Smobiler.Core.PointS(1F, 0F);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.SizeF(30F, 15F);
            this.button3.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button3.TabIndex = 9;
            this.button3.Text = "<<";
            this.button3.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button3_Click);
            // 
            // Select
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.datePicker1,
            this.label4,
            this.button1,
            this.button2,
            this.button3});
            this.TitleBackColor = System.Drawing.Color.Turquoise;
            this.TitleText = "查询方式";
            this.TitleTextColor = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Select_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.DatePicker datePicker1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button3;
    }
}