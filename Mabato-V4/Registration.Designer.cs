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
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Hint = "Username";
            this.txtusername.Location = new System.Drawing.Point(35, 94);
            this.txtusername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.Size = new System.Drawing.Size(258, 23);
            this.txtusername.TabIndex = 0;
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(35, 123);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(258, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtConpass
            // 
            this.txtConpass.Depth = 0;
            this.txtConpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConpass.Hint = "Confirm Password";
            this.txtConpass.Location = new System.Drawing.Point(35, 152);
            this.txtConpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConpass.Name = "txtConpass";
            this.txtConpass.PasswordChar = '*';
            this.txtConpass.SelectedText = "";
            this.txtConpass.SelectionLength = 0;
            this.txtConpass.SelectionStart = 0;
            this.txtConpass.Size = new System.Drawing.Size(258, 23);
            this.txtConpass.TabIndex = 2;
            this.txtConpass.UseSystemPasswordChar = false;
            this.txtConpass.Click += new System.EventHandler(this.txtConpass_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 197);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Admin?";
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.Depth = 0;
            this.btnYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnYes.Location = new System.Drawing.Point(102, 193);
            this.btnYes.Margin = new System.Windows.Forms.Padding(0);
            this.btnYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Ripple = true;
            this.btnYes.Size = new System.Drawing.Size(53, 30);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = true;
            this.btnlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Depth = 0;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogin.Location = new System.Drawing.Point(82, 391);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Primary = false;
            this.btnlogin.Size = new System.Drawing.Size(179, 36);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Go back to login page?";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnRegister.Location = new System.Drawing.Point(118, 357);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(105, 33);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.Black;
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 442);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
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