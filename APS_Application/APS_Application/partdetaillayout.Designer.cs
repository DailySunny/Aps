using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class partdetaillayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public partdetaillayout()
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
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            // 
            // label7
            // 
            this.label7.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label7.DataMember = "Plan_Date";
            this.label7.DisplayMember = "Plan_Date";
            this.label7.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.SizeF(20F, 10F);
            this.label7.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label8.DataMember = "Plan_Week";
            this.label8.DisplayMember = "Plan_Week";
            this.label8.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label8.Location = new Smobiler.Core.PointS(20F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.SizeF(10F, 10F);
            this.label8.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.DataMember = "Demand";
            this.label9.DisplayMember = "Demand";
            this.label9.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label9.Location = new Smobiler.Core.PointS(30F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.SizeF(30F, 15F);
            this.label9.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Border = new Smobiler.Core.Border(1, 0, 1, 0);
            this.label10.DataMember = "Plan_QTY";
            this.label10.DisplayMember = "Plan_QTY";
            this.label10.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label10.Location = new Smobiler.Core.PointS(60F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.SizeF(20F, 10F);
            this.label10.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label11.DataMember = "Plan_Stock";
            this.label11.DisplayMember = "Plan_Stock";
            this.label11.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label11.Location = new Smobiler.Core.PointS(80F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.SizeF(20F, 10F);
            this.label11.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.DataMember = "Bankin";
            this.label12.DisplayMember = "Bankin";
            this.label12.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label12.Location = new Smobiler.Core.PointS(100F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.SizeF(20F, 10F);
            this.label12.TabIndex = 13;
            // 
            // partdetaillayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.label8,
            this.label9,
            this.label10,
            this.label11,
            this.label12});
            this.Size = new System.Drawing.Size(120, 15);

        }
        #endregion

        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Label label12;
    }
}