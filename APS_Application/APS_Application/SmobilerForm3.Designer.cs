using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class MenuForm : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public MenuForm()
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
            this.function = new Smobiler.Core.Controls.Label();
            this.nextweek = new Smobiler.Core.Controls.ImageButton();
            this.thisweek = new Smobiler.Core.Controls.ImageButton();
            this.hstoryweek = new Smobiler.Core.Controls.ImageButton();
            // 
            // function
            // 
            this.function.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.function.FontSize = 12F;
            this.function.ForeColor = System.Drawing.Color.White;
            this.function.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.function.Name = "function";
            this.function.Size = new System.Drawing.SizeF(120F, 15F);
            this.function.TabIndex = 4;
            this.function.Text = "周计划查询";
            // 
            // nextweek
            // 
            this.nextweek.FontSize = 8F;
            this.nextweek.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nextweek.Location = new Smobiler.Core.PointS(15F, 31F);
            this.nextweek.Name = "nextweek";
            this.nextweek.ResourceID = "nextweek";
            this.nextweek.Size = new System.Drawing.SizeF(35F, 35F);
            this.nextweek.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.nextweek.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.nextweek.TabIndex = 5;
            this.nextweek.Text = "查询计划";
            this.nextweek.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.nextweek_Click);
            // 
            // thisweek
            // 
            this.thisweek.FontSize = 8F;
            this.thisweek.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.thisweek.Location = new Smobiler.Core.PointS(65F, 30F);
            this.thisweek.Name = "thisweek";
            this.thisweek.ResourceID = "thisweek";
            this.thisweek.Size = new System.Drawing.SizeF(35F, 35F);
            this.thisweek.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.thisweek.TabIndex = 6;
            this.thisweek.Text = "本周计划";
            this.thisweek.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.thisweek_Click);
            // 
            // hstoryweek
            // 
            this.hstoryweek.FontSize = 8F;
            this.hstoryweek.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hstoryweek.Location = new Smobiler.Core.PointS(15F, 79F);
            this.hstoryweek.Name = "hstoryweek";
            this.hstoryweek.ResourceID = "historyweek";
            this.hstoryweek.Size = new System.Drawing.SizeF(35F, 35F);
            this.hstoryweek.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.hstoryweek.TabIndex = 7;
            this.hstoryweek.Text = "历史计划";
            // 
            // MenuForm
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.function,
            this.nextweek,
            this.thisweek,
            this.hstoryweek});
            this.LeftFormLayout = "UserInfo";
            this.TitleBackColor = System.Drawing.Color.Cyan;
            this.TitleText = "MENU";
            this.Load += new System.EventHandler(this.MenuForm_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label function;
        private Smobiler.Core.Controls.ImageButton nextweek;
        private Smobiler.Core.Controls.ImageButton thisweek;
        private Smobiler.Core.Controls.ImageButton hstoryweek;

    }
}