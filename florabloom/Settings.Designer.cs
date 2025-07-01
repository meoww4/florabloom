namespace florabloom
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            FlowerCb = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            PriceTb = new TextBox();
            Backbt = new Label();
            SubmitBtn = new Button();
            SuspendLayout();
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
            label1.Location = new Point(396, 34);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 2;
            label1.Text = "FlowerBloom";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(421, 77);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 3;
            label2.Text = "Настройки";
            // 
            // FlowerCb
            // 
            FlowerCb.FormattingEnabled = true;
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
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 6;
            label4.Text = "Введите цену";
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceTb.Location = new Point(362, 364);
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
            Backbt.Name = "Backbt";
            Backbt.Size = new Size(64, 24);
            Backbt.TabIndex = 10;
            Backbt.Text = "Назад";
            Backbt.Click += Backbt_Click;
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
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(766, 655);
            Controls.Add(SubmitBtn);
            Controls.Add(Backbt);
            Controls.Add(PriceTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FlowerCb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FlowerCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label Backbt;
        private System.Windows.Forms.Button SubmitBtn;
    }
}
