using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class partselectlayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public partselectlayout()
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
            // 
            // label1
            // 
            this.label1.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.label1.DataMember = "Part_No";
            this.label1.DisplayMember = "Part_No";
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(60F, 15F);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.DataMember = "Part_Name";
            this.label2.DisplayMember = "Part_Name";
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new Smobiler.Core.PointS(60F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(60F, 15F);
            this.label2.TabIndex = 3;
            // 
            // partselectlayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2});
            this.Size = new System.Drawing.Size(120, 17);
            this.Load += new System.EventHandler(this.partselectlayout_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}