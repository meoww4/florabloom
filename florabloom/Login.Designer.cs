namespace florabloom
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private Label label2;
        private Label label3;
        private Button LoginBtn;
        private Button RegisterBtn;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginBtn = new Button();
            RegisterBtn = new Button();
            eyeIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Trebuchet MS", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 592);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(506, 56);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 1;
            label1.Text = "FloraBloom";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Trebuchet MS", 14.25F);
            UnameTb.Location = new Point(480, 306);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(198, 30);
            UnameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Trebuchet MS", 14.25F);
            PasswordTb.Location = new Point(480, 394);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(198, 30);
            PasswordTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(542, 263);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(539, 354);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.LightPink;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Trebuchet MS", 14.25F);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(480, 466);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(196, 39);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Войти";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click_1;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.White;
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatAppearance.BorderColor = Color.LightPink;
            RegisterBtn.FlatAppearance.BorderSize = 2;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Trebuchet MS", 14.25F);
            RegisterBtn.ForeColor = Color.LightPink;
            RegisterBtn.Location = new Point(480, 515);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(196, 39);
            RegisterBtn.TabIndex = 8;
            RegisterBtn.Text = "Регистрация";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // eyeIcon
            // 
            eyeIcon.Cursor = Cursors.Hand;
            eyeIcon.Location = new Point(675, 394);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(30, 30);
            eyeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeIcon.TabIndex = 10;
            eyeIcon.TabStop = false;
            eyeIcon.Click += EyeIcon_Click;
            // 
            // Login
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(850, 592);
            Controls.Add(eyeIcon);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(UnameTb);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            Load += Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox eyeIcon;
    }
}