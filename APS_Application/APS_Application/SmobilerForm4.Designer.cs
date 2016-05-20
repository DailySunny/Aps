using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class NextWeek : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public NextWeek()
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
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.next_ver = new Smobiler.Core.Controls.Button();
            this.history_ver = new Smobiler.Core.Controls.Button();
            // 
            // gridView1
            // 
            this.gridView1.AllowSlip = true;
            this.gridView1.Layout = "DataShow";
            this.gridView1.Location = new Smobiler.Core.PointS(0F, 40F);
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(184F, 160F);
            this.gridView1.TabIndex = 4;
            this.gridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridView1_CellClick);
            this.gridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridView1_ItemClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.FontSize = 10F;
            this.label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.SizeF(200F, 20F);
            this.label3.TabIndex = 5;
            // 
            // next_ver
            // 
            this.next_ver.FontSize = 10F;
            this.next_ver.Location = new Smobiler.Core.PointS(0F, 20F);
            this.next_ver.Name = "next_ver";
            this.next_ver.Size = new System.Drawing.SizeF(100F, 20F);
            this.next_ver.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.next_ver.TabIndex = 6;
            this.next_ver.Text = "周计划";
            this.next_ver.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.next_ver_Click);
            // 
            // history_ver
            // 
            this.history_ver.FontSize = 10F;
            this.history_ver.Location = new Smobiler.Core.PointS(100F, 20F);
            this.history_ver.Name = "history_ver";
            this.history_ver.Size = new System.Drawing.SizeF(100F, 20F);
            this.history_ver.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.history_ver.TabIndex = 7;
            this.history_ver.Text = "历史版本";
            this.history_ver.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.history_ver_Click);
            // 
            // NextWeek
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridView1,
            this.label3,
            this.next_ver,
            this.history_ver});
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.NextWeek_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button next_ver;
        private Smobiler.Core.Controls.Button history_ver;
        internal Smobiler.Core.Controls.GridView gridView1;
    }
}