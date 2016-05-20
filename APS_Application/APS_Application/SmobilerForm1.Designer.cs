using Smobiler.Core;

namespace APS_Application
{
    partial class LoginForm : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public LoginForm()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.login_name = new Smobiler.Core.Controls.TextBox();
            this.login_pwd = new Smobiler.Core.Controls.TextBox();
            this.login = new Smobiler.Core.Controls.Switch();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.switch1 = new Smobiler.Core.Controls.Switch();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BackColorAlpha = 0;
            this.label1.Bold = true;
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Location = new Smobiler.Core.PointS(9F, 21F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(101F, 44F);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pro PLAN";
            // 
            // login_name
            // 
            this.login_name.BackColor = System.Drawing.Color.LawnGreen;
            this.login_name.BorderColor = System.Drawing.Color.White;
            this.login_name.ForeColor = System.Drawing.Color.White;
            this.login_name.Location = new Smobiler.Core.PointS(20F, 73F);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.SizeF(69F, 10F);
            this.login_name.TabIndex = 6;
            this.login_name.WaterMarkText = "Username";
            // 
            // login_pwd
            // 
            this.login_pwd.BackColor = System.Drawing.Color.LawnGreen;
            this.login_pwd.BorderColor = System.Drawing.Color.White;
            this.login_pwd.ForeColor = System.Drawing.Color.White;
            this.login_pwd.Location = new Smobiler.Core.PointS(20F, 97F);
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.PasswordChar = '*';
            this.login_pwd.Size = new System.Drawing.SizeF(69F, 10F);
            this.login_pwd.TabIndex = 7;
            this.login_pwd.WaterMarkText = "Password";
            // 
            // login
            // 
            this.login.BackColorAlpha = 0;
            this.login.Checked = false;
            this.login.Location = new Smobiler.Core.PointS(93F, 86F);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.SizeF(17F, 10F);
            this.login.TabIndex = 8;
            this.login.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.login_CheckChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.BackColorAlpha = 0;
            this.label2.Bold = true;
            this.label2.FontSize = 8F;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new Smobiler.Core.PointS(33F, 126F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(40F, 10F);
            this.label2.TabIndex = 9;
            this.label2.Text = "忘记密码？";
            // 
            // switch1
            // 
            this.switch1.BackColorAlpha = 0;
            this.switch1.Checked = false;
            this.switch1.Location = new Smobiler.Core.PointS(93F, 125F);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.SizeF(17F, 10F);
            this.switch1.TabIndex = 10;
            this.switch1.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.switch1_CheckChanged);
            // 
            // LoginForm
            // 
            this.AllowSlip = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.login_name,
            this.login_pwd,
            this.login,
            this.label2,
            this.switch1});
            this.TitleBackColor = System.Drawing.Color.White;
            this.TitleText = "生产周计划查询";
            this.TitleTextColor = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox login_name;
        private Smobiler.Core.Controls.TextBox login_pwd;
        private Smobiler.Core.Controls.Switch login;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Switch switch1;

    }
}