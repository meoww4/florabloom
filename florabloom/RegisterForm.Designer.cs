namespace florabloom
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label UsernameLbl;
        private TextBox RegisterUnameTb;
        private Label PasswordLbl;
        private TextBox RegisterPasswordTb;
        private Label RoleLbl;
        private ComboBox RegisterRoleCb;
        private Label MasterPasswordLbl;
        private TextBox MasterPasswordTb;
        private Button RegisterConfirmBtn;
        private Button RegisterCancelBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            UsernameLbl = new Label();
            RegisterUnameTb = new TextBox();
            PasswordLbl = new Label();
            RegisterPasswordTb = new TextBox();
            RoleLbl = new Label();
            RegisterRoleCb = new ComboBox();
            MasterPasswordLbl = new Label();
            MasterPasswordTb = new TextBox();
            RegisterConfirmBtn = new Button();
            RegisterCancelBtn = new Button();
            SuspendLayout();
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Font = new Font("Segoe UI", 15.75F);
            UsernameLbl.Location = new Point(39, 51);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(76, 30);
            UsernameLbl.TabIndex = 0;
            UsernameLbl.Text = "Логин:";
            // 
            // RegisterUnameTb
            // 
            RegisterUnameTb.Font = new Font("Segoe UI", 15.75F);
            RegisterUnameTb.Location = new Point(309, 48);
            RegisterUnameTb.Name = "RegisterUnameTb";
            RegisterUnameTb.Size = new Size(180, 35);
            RegisterUnameTb.TabIndex = 1;
            RegisterUnameTb.TextChanged += RegisterUnameTb_TextChanged;
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Font = new Font("Segoe UI", 15.75F);
            PasswordLbl.Location = new Point(39, 113);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(90, 30);
            PasswordLbl.TabIndex = 2;
            PasswordLbl.Text = "Пароль:";
            // 
            // RegisterPasswordTb
            // 
            RegisterPasswordTb.Font = new Font("Segoe UI", 15.75F);
            RegisterPasswordTb.Location = new Point(309, 113);
            RegisterPasswordTb.Name = "RegisterPasswordTb";
            RegisterPasswordTb.PasswordChar = '●';
            RegisterPasswordTb.Size = new Size(180, 35);
            RegisterPasswordTb.TabIndex = 3;
            // 
            // RoleLbl
            // 
            RoleLbl.AutoSize = true;
            RoleLbl.Font = new Font("Segoe UI", 15.75F);
            RoleLbl.Location = new Point(39, 188);
            RoleLbl.Name = "RoleLbl";
            RoleLbl.Size = new Size(164, 30);
            RoleLbl.TabIndex = 4;
            RoleLbl.Text = "Выберите роль:";
            // 
            // RegisterRoleCb
            // 
            RegisterRoleCb.Cursor = Cursors.Hand;
            RegisterRoleCb.DropDownStyle = ComboBoxStyle.DropDownList;
            RegisterRoleCb.Font = new Font("Segoe UI", 15.75F);
            RegisterRoleCb.Items.AddRange(new object[] { "user", "admin" });
            RegisterRoleCb.Location = new Point(309, 188);
            RegisterRoleCb.Name = "RegisterRoleCb";
            RegisterRoleCb.Size = new Size(180, 38);
            RegisterRoleCb.TabIndex = 5;
            // 
            // MasterPasswordLbl
            // 
            MasterPasswordLbl.AutoSize = true;
            MasterPasswordLbl.Font = new Font("Segoe UI", 15.75F);
            MasterPasswordLbl.Location = new Point(39, 261);
            MasterPasswordLbl.Name = "MasterPasswordLbl";
            MasterPasswordLbl.Size = new Size(167, 30);
            MasterPasswordLbl.TabIndex = 6;
            MasterPasswordLbl.Text = "Мастер-пароль:";
            // 
            // MasterPasswordTb
            // 
            MasterPasswordTb.Font = new Font("Segoe UI", 15.75F);
            MasterPasswordTb.Location = new Point(309, 258);
            MasterPasswordTb.Name = "MasterPasswordTb";
            MasterPasswordTb.PasswordChar = '●';
            MasterPasswordTb.Size = new Size(180, 35);
            MasterPasswordTb.TabIndex = 7;
            // 
            // RegisterConfirmBtn
            // 
            RegisterConfirmBtn.BackColor = Color.LightPink;
            RegisterConfirmBtn.Cursor = Cursors.Hand;
            RegisterConfirmBtn.Font = new Font("Trebuchet MS", 14.25F);
            RegisterConfirmBtn.ForeColor = Color.White;
            RegisterConfirmBtn.Location = new Point(39, 365);
            RegisterConfirmBtn.Name = "RegisterConfirmBtn";
            RegisterConfirmBtn.Size = new Size(199, 39);
            RegisterConfirmBtn.TabIndex = 8;
            RegisterConfirmBtn.Text = "Зарегистрироваться";
            RegisterConfirmBtn.UseVisualStyleBackColor = false;
            RegisterConfirmBtn.Click += RegisterConfirmBtn_Click;
            // 
            // RegisterCancelBtn
            // 
            RegisterCancelBtn.BackColor = Color.LightPink;
            RegisterCancelBtn.Cursor = Cursors.Hand;
            RegisterCancelBtn.Font = new Font("Trebuchet MS", 14.25F);
            RegisterCancelBtn.ForeColor = Color.White;
            RegisterCancelBtn.Location = new Point(293, 365);
            RegisterCancelBtn.Name = "RegisterCancelBtn";
            RegisterCancelBtn.Size = new Size(196, 39);
            RegisterCancelBtn.TabIndex = 9;
            RegisterCancelBtn.Text = "Отмена";
            RegisterCancelBtn.UseVisualStyleBackColor = false;
            RegisterCancelBtn.Click += RegisterCancelBtn_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(558, 458);
            Controls.Add(UsernameLbl);
            Controls.Add(RegisterUnameTb);
            Controls.Add(PasswordLbl);
            Controls.Add(RegisterPasswordTb);
            Controls.Add(RoleLbl);
            Controls.Add(RegisterRoleCb);
            Controls.Add(MasterPasswordLbl);
            Controls.Add(MasterPasswordTb);
            Controls.Add(RegisterConfirmBtn);
            Controls.Add(RegisterCancelBtn);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация пользователя";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
