namespace florabloom
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(286, 552);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(551, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 1;
            label1.Text = "FloraBloom";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(566, 103);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnameTb.Location = new Point(525, 305);
            UnameTb.Margin = new Padding(4, 5, 4, 5);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(198, 30);
            UnameTb.TabIndex = 3;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTb.Location = new Point(525, 393);
            PasswordTb.Margin = new Padding(4, 5, 4, 5);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(198, 30);
            PasswordTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 262);
            label2.Name = "label2";
            label2.Size = new Size(63, 24);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 353);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Trebuchet MS", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.LightPink;
            label4.Location = new Point(895, 21);
            label4.Name = "label4";
            label4.Size = new Size(26, 28);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.LightPink;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(525, 465);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(196, 39);
            LoginBtn.TabIndex = 21;
            LoginBtn.Text = "Войти";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 552);
            Controls.Add(LoginBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private TextBox UnameTb;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox PasswordTb;
        private Label label4;
        private Button LoginBtn;
    }
}
