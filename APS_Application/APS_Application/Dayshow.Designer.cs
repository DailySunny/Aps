using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class Dayshow : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public Dayshow()
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
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(120F, 15F);
            this.label1.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.AllowSlip = true;
            this.gridView1.Layout = "dayshowlayout";
            this.gridView1.Location = new Smobiler.Core.PointS(0F, 25F);
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(120F, 175F);
            this.gridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.BackColorAlpha = 0;
            this.button1.FontSize = 8F;
            this.button1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.button1.Location = new Smobiler.Core.PointS(1F, 0F);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.SizeF(30F, 14F);
            this.button1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button1.TabIndex = 4;
            this.button1.Text = "<<";
            this.button1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.BorderRadius = 4;
            this.button2.Location = new Smobiler.Core.PointS(0F, 15F);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.SizeF(60F, 10F);
            this.button2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button2.TabIndex = 5;
            this.button2.Text = "前一天";
            this.button2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.BorderRadius = 4;
            this.button3.Location = new Smobiler.Core.PointS(60F, 15F);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.SizeF(60F, 10F);
            this.button3.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button3.TabIndex = 6;
            this.button3.Text = "后一天";
            this.button3.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button3_Click);
            // 
            // Dayshow
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.gridView1,
            this.button1,
            this.button2,
            this.button3});
            this.TitleBackColor = System.Drawing.Color.Turquoise;
            this.TitleText = "日期查询零件详情";
            this.TitleTextColor = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Dayshow_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
        internal Smobiler.Core.Controls.GridView gridView1;
    }
}