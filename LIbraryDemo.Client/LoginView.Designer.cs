namespace LIbraryDemo.Client
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            btnLogin = new ReaLTaiizor.Controls.Button();
            txtEmail = new ReaLTaiizor.Controls.BigTextBox();
            txtPassword = new ReaLTaiizor.Controls.BigTextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            loading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loading).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Image = null;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.FromArgb(32, 34, 37);
            btnLogin.Location = new Point(82, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogin.Size = new Size(316, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Image = null;
            txtEmail.Location = new Point(82, 51);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = false;
            txtEmail.Size = new Size(316, 46);
            txtEmail.TabIndex = 6;
            txtEmail.TextAlignment = HorizontalAlignment.Left;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Image = null;
            txtPassword.Location = new Point(82, 139);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(316, 46);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlignment = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(100, 23);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(58, 25);
            dungeonLabel1.TabIndex = 8;
            dungeonLabel1.Text = "Email";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(100, 111);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(91, 25);
            dungeonLabel2.TabIndex = 9;
            dungeonLabel2.Text = "Password";
            // 
            // loading
            // 
            loading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loading.Image = (Image)resources.GetObject("loading.Image");
            loading.Location = new Point(202, 228);
            loading.Name = "loading";
            loading.Size = new Size(64, 51);
            loading.SizeMode = PictureBoxSizeMode.Zoom;
            loading.TabIndex = 10;
            loading.TabStop = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 317);
            Controls.Add(loading);
            Controls.Add(dungeonLabel2);
            Controls.Add(dungeonLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(500, 364);
            MinimumSize = new Size(500, 364);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to LibraryDemo";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)loading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button btnLogin;
        private ReaLTaiizor.Controls.BigTextBox txtEmail;
        private ReaLTaiizor.Controls.BigTextBox txtPassword;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private PictureBox loading;
    }
}