using System;
using Smobiler.Core;
namespace APS_Application
{
    partial class UserInfo : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public UserInfo()
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
            this.line1 = new Smobiler.Core.Controls.Line();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.username = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // line1
            // 
            this.line1.Location = new Smobiler.Core.PointS(121F, 43F);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.SizeF(30F, 1F);
            this.line1.TabIndex = 5;
            // 
            // image1
            // 
            this.image1.BackColorAlpha = 0;
            this.image1.Name = "image1";
            this.image1.ResourceID = "userinfoback";
            this.image1.Size = new System.Drawing.SizeF(80F, 200F);
            this.image1.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.image1.TabIndex = 14;
            // 
            // username
            // 
            this.username.BackColorAlpha = 0;
            this.username.FontSize = 8F;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.username.Location = new Smobiler.Core.PointS(35F, 61F);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.SizeF(44F, 15F);
            this.username.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColorAlpha = 0;
            this.label1.FontSize = 8F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Location = new Smobiler.Core.PointS(35F, 106F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(44F, 15F);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColorAlpha = 0;
            this.label2.FontSize = 8F;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new Smobiler.Core.PointS(35F, 155F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(44F, 15F);
            this.label2.TabIndex = 21;
            // 
            // UserInfo
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.line1,
            this.image1,
            this.username,
            this.label1,
            this.label2});
            this.Size = new System.Drawing.Size(80, 200);
            this.TitleBackColor = System.Drawing.Color.White;
            this.TitleImage = "user1";
            this.TitleText = "”√     ªß";
            this.TitleTextColor = System.Drawing.Color.CornflowerBlue;
            this.Load += new System.EventHandler(this.UserInfo_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label username;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}