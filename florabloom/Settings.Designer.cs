namespace florabloom
{
    partial class Settings
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
            components = new System.ComponentModel.Container();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            FlowerCb = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            PriceTb = new TextBox();
            Backbt = new Label();
            label5 = new Label();
            SubmitBtn = new Button();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 655);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(408, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 2;
            label1.Text = "FloraBloom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(421, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 3;
            label2.Text = "Настройки";
            // 
            // FlowerCb
            // 
            FlowerCb.FormattingEnabled = true;
            FlowerCb.Items.AddRange(new object[] { "Большой (15+ цветов)", "Средний (8–15 цветов)", "Маленький (до 7 цветов)" });
            FlowerCb.Location = new Point(362, 242);
            FlowerCb.Name = "FlowerCb";
            FlowerCb.Size = new Size(212, 30);
            FlowerCb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label3.ForeColor = Color.LightPink;
            label3.Location = new Point(362, 203);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 24);
            label3.TabIndex = 5;
            label3.Text = "Выберите букет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label4.ForeColor = Color.LightPink;
            label4.Location = new Point(362, 310);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 6;
            label4.Text = "Введите цену";
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceTb.Location = new Point(362, 364);
            PriceTb.Margin = new Padding(4, 5, 4, 5);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(212, 30);
            PriceTb.TabIndex = 7;
            // 
            // Backbt
            // 
            Backbt.AutoSize = true;
            Backbt.Cursor = Cursors.Hand;
            Backbt.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            Backbt.ForeColor = Color.LightPink;
            Backbt.Location = new Point(432, 570);
            Backbt.Margin = new Padding(4, 0, 4, 0);
            Backbt.Name = "Backbt";
            Backbt.Size = new Size(64, 24);
            Backbt.TabIndex = 10;
            Backbt.Text = "Назад";
            Backbt.Click += Backbt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Trebuchet MS", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.LightPink;
            label5.Location = new Point(681, 25);
            label5.Name = "label5";
            label5.Size = new Size(26, 28);
            label5.TabIndex = 11;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.LightPink;
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(362, 440);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(196, 39);
            SubmitBtn.TabIndex = 21;
            SubmitBtn.Text = "Сохранить";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click_1;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 655);
            Controls.Add(SubmitBtn);
            Controls.Add(label5);
            Controls.Add(Backbt);
            Controls.Add(PriceTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FlowerCb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private ComboBox FlowerCb;
        private Label label2;
        private Label label4;
        private TextBox PriceTb;
        private Label Backbt;
        private Label label5;
        private Button SubmitBtn;
    }
}