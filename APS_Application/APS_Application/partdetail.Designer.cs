using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class partdetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public partdetail()
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
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(60F, 10F);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Border = new Smobiler.Core.Border(1, 0, 0, 0);
            this.label2.DataMember = "Part_Name";
            this.label2.DisplayMember = "Part_Name";
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new Smobiler.Core.PointS(60F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(60F, 10F);
            this.label2.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Layout = "partdetaillayout";
            this.gridView1.Location = new Smobiler.Core.PointS(0F, 20F);
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(120F, 180F);
            this.gridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.BackColorAlpha = 0;
            this.button1.FontSize = 8F;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.SizeF(10F, 10F);
            this.button1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button1.TabIndex = 5;
            this.button1.Text = "<<";
            this.button1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label3.Location = new Smobiler.Core.PointS(0F, 10F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.SizeF(20F, 10F);
            this.label3.TabIndex = 6;
            this.label3.Text = "日期";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label4.Location = new Smobiler.Core.PointS(20F, 10F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.SizeF(10F, 10F);
            this.label4.TabIndex = 7;
            this.label4.Text = "周";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label5.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label5.Location = new Smobiler.Core.PointS(30F, 10F);
            this.label5.Name = "label5";
            this.label5.TabIndex = 8;
            this.label5.Text = "需求方/数量";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label6.Location = new Smobiler.Core.PointS(60F, 10F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.SizeF(20F, 10F);
            this.label6.TabIndex = 9;
            this.label6.Text = "生产";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label7.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label7.Location = new Smobiler.Core.PointS(80F, 10F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.SizeF(20F, 10F);
            this.label7.TabIndex = 10;
            this.label7.Text = "库存";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label8.Location = new Smobiler.Core.PointS(100F, 10F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.SizeF(20F, 10F);
            this.label8.TabIndex = 11;
            this.label8.Text = "BANKIN";
            // 
            // partdetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.gridView1,
            this.button1,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.label7,
            this.label8});
            this.TitleBackColor = System.Drawing.Color.Turquoise;
            this.TitleText = "单个零件周计划";
            this.TitleTextColor = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.partdetaillayout_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.GridView gridView1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
    }
}