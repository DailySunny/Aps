using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class partselect : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public partselect()
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // gridView1
            // 
            this.gridView1.Layout = "partselectlayout";
            this.gridView1.Location = new Smobiler.Core.PointS(0F, 28F);
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(120F, 175F);
            this.gridView1.TabIndex = 2;
            this.gridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridView1_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Location = new Smobiler.Core.PointS(0F, 10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(60F, 15F);
            this.label1.TabIndex = 3;
            this.label1.Text = "零件号";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new Smobiler.Core.PointS(60F, 10F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(60F, 15F);
            this.label2.TabIndex = 4;
            this.label2.Text = "零件名";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FontSize = 10F;
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.button1.HoverForeColor = System.Drawing.Color.DarkRed;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.SizeF(120F, 10F);
            this.button1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.button1.TabIndex = 5;
            this.button1.Text = "<<";
            this.button1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.button1_Click);
            // 
            // partselect
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridView1,
            this.label1,
            this.label2,
            this.button1});
            this.TitleBackColor = System.Drawing.Color.Turquoise;
            this.TitleText = "零件清单列表";
            this.TitleTextColor = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.partselect_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.GridView gridView1;
        private Smobiler.Core.Controls.Button button1;
    }
}