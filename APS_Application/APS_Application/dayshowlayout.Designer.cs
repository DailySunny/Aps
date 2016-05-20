using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class dayshowlayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public dayshowlayout()
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
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.label13 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.DataMember = "Part_No";
            this.label1.DisplayMember = "Part_No";
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(60F, 10F);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.DataMember = "Part_Name";
            this.label2.DisplayMember = "Part_Name";
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new Smobiler.Core.PointS(60F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(60F, 10F);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label3.Location = new Smobiler.Core.PointS(0F, 10F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.SizeF(24F, 10F);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seq";
            // 
            // label4
            // 
            this.label4.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label4.Location = new Smobiler.Core.PointS(24F, 10F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.SizeF(24F, 10F);
            this.label4.TabIndex = 5;
            this.label4.Text = "需求方";
            // 
            // label5
            // 
            this.label5.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.label5.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label5.Location = new Smobiler.Core.PointS(48F, 10F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.SizeF(24F, 10F);
            this.label5.TabIndex = 6;
            this.label5.Text = "生产计划";
            // 
            // label6
            // 
            this.label6.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label6.Location = new Smobiler.Core.PointS(72F, 10F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.SizeF(24F, 10F);
            this.label6.TabIndex = 7;
            this.label6.Text = "下班库存";
            // 
            // label7
            // 
            this.label7.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.label7.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label7.Location = new Smobiler.Core.PointS(96F, 10F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.SizeF(24F, 10F);
            this.label7.TabIndex = 8;
            this.label7.Text = "BANK IN";
            // 
            // label8
            // 
            this.label8.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label8.DataMember = "Plan_Sequence";
            this.label8.DisplayMember = "Plan_Sequence";
            this.label8.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label8.Location = new Smobiler.Core.PointS(0F, 20F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.SizeF(24F, 20F);
            this.label8.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label9.DataMember = "Demand";
            this.label9.DisplayMember = "Demand";
            this.label9.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label9.Location = new Smobiler.Core.PointS(24F, 20F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.SizeF(24F, 20F);
            this.label9.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label10.DataMember = "Plan_QTY";
            this.label10.DisplayMember = "Plan_QTY";
            this.label10.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label10.Location = new Smobiler.Core.PointS(48F, 20F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.SizeF(24F, 20F);
            this.label10.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new Smobiler.Core.PointS(72F, 20F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.SizeF(24F, 20F);
            this.label11.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label12.DataMember = "Plan_Stock";
            this.label12.DisplayMember = "Plan_Stock";
            this.label12.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label12.Location = new Smobiler.Core.PointS(72F, 20F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.SizeF(24F, 20F);
            this.label12.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.DataMember = "Bankin";
            this.label13.DisplayMember = "Bankin";
            this.label13.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label13.Location = new Smobiler.Core.PointS(96F, 20F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.SizeF(24F, 20F);
            this.label13.TabIndex = 13;
            // 
            // dayshowlayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.label7,
            this.label8,
            this.label9,
            this.label10,
            this.label12,
            this.label13});
            this.Size = new System.Drawing.Size(120, 42);

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Label label12;
        private Smobiler.Core.Controls.Label label13;
    }
}