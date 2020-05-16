namespace Mabato_V4
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txtusername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnYes = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnlogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegister = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Depth = 0;
            resources.ApplyResources(this.txtusername, "txtusername");
            this.txtusername.Hint = "Username";
            this.txtusername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Hint = "Password";
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtConpass
            // 
            this.txtConpass.Depth = 0;
            resources.ApplyResources(this.txtConpass, "txtConpass");
            this.txtConpass.Hint = "Confirm Password";
            this.txtConpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConpass.Name = "txtConpass";
            this.txtConpass.PasswordChar = '*';
            this.txtConpass.SelectedText = "";
            this.txtConpass.SelectionLength = 0;
            this.txtConpass.SelectionStart = 0;
            this.txtConpass.UseSystemPasswordChar = false;
            this.txtConpass.Click += new System.EventHandler(this.txtConpass_Click);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // btnYes
            // 
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.Depth = 0;
            this.btnYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Ripple = true;
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Depth = 0;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Primary = false;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.ButtonText = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledColor = System.Drawing.Color.DimGray;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = null;
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = true;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = true;
            this.btnRegister.IconZoom = 90D;
            this.btnRegister.IsTab = false;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.Black;
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // Registration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtConpass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtusername);
            this.Name = "Registration";
            this.Opacity = 0.9D;
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtusername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConpass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox btnYes;
        private MaterialSkin.Controls.MaterialFlatButton btnlogin;
        private ns1.BunifuFlatButton btnRegister;
    }
}