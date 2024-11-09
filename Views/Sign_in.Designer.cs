namespace WinFormsCore.Views
{
    partial class Sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in));
            container = new Panel();
            btn_SignIn = new Button();
            tbx_password = new TextBox();
            tbx_username = new TextBox();
            lbl_password = new Label();
            lbl_username = new Label();
            ptb_logo = new PictureBox();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_logo).BeginInit();
            SuspendLayout();
            // 
            // container
            // 
            container.Controls.Add(btn_SignIn);
            container.Controls.Add(tbx_password);
            container.Controls.Add(tbx_username);
            container.Controls.Add(lbl_password);
            container.Controls.Add(lbl_username);
            container.Location = new Point(93, 171);
            container.Name = "container";
            container.Size = new Size(593, 189);
            container.TabIndex = 0;
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = SystemColors.ActiveCaptionText;
            btn_SignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SignIn.ForeColor = Color.Transparent;
            btn_SignIn.Location = new Point(241, 130);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(123, 40);
            btn_SignIn.TabIndex = 4;
            btn_SignIn.Text = "Đăng nhập";
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // tbx_password
            // 
            tbx_password.BorderStyle = BorderStyle.FixedSingle;
            tbx_password.Location = new Point(192, 83);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(299, 27);
            tbx_password.TabIndex = 3;
            // 
            // tbx_username
            // 
            tbx_username.BorderStyle = BorderStyle.FixedSingle;
            tbx_username.Location = new Point(192, 29);
            tbx_username.Name = "tbx_username";
            tbx_username.Size = new Size(299, 27);
            tbx_username.TabIndex = 2;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_password.Location = new Point(86, 83);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(74, 20);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Mật khẩu";
            lbl_password.Click += label1_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_username.Location = new Point(86, 31);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(75, 20);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "Tài khoản";
            // 
            // ptb_logo
            // 
            ptb_logo.BackColor = SystemColors.Control;
            ptb_logo.Image = (Image)resources.GetObject("ptb_logo.Image");
            ptb_logo.Location = new Point(334, 92);
            ptb_logo.Name = "ptb_logo";
            ptb_logo.Size = new Size(123, 82);
            ptb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_logo.TabIndex = 1;
            ptb_logo.TabStop = false;
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(ptb_logo);
            Controls.Add(container);
            Name = "Sign_in";
            Text = "Sign_in";
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel container;
        private PictureBox ptb_logo;
        private Label lbl_password;
        private Label lbl_username;
        private Button btn_SignIn;
        private TextBox tbx_password;
        private TextBox tbx_username;
    }
}