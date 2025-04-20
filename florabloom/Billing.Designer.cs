namespace florabloom
{
    partial class Billing
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            LargeBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            MediumBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            SmallBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            label1 = new Label();
            BilliDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            QtyTb = new TextBox();
            label3 = new Label();
            label5 = new Label();
            Logoutbtn = new Button();
            PrintBtn = new Button();
            OrderBtn = new Button();
            SettingBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BilliDGV).BeginInit();
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
            panel1.Size = new Size(91, 787);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(119, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 6;
            label2.Text = "FloraBloom";
            // 
            // panel2
            // 
            panel2.Controls.Add(LargeBtn);
            panel2.Controls.Add(MediumBtn);
            panel2.Controls.Add(SmallBtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(141, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 304);
            panel2.TabIndex = 7;
            // 
            // LargeBtn
            // 
            LargeBtn.AutoSize = true;
            LargeBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            LargeBtn.CheckedState.BorderThickness = 0;
            LargeBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            LargeBtn.CheckedState.InnerColor = Color.White;
            LargeBtn.CheckedState.InnerOffset = -4;
            LargeBtn.Location = new Point(26, 181);
            LargeBtn.Name = "LargeBtn";
            LargeBtn.Size = new Size(189, 26);
            LargeBtn.TabIndex = 11;
            LargeBtn.Text = "Большой (15+ цветов)";
            LargeBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            LargeBtn.UncheckedState.BorderThickness = 2;
            LargeBtn.UncheckedState.FillColor = Color.Transparent;
            LargeBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // MediumBtn
            // 
            MediumBtn.AutoSize = true;
            MediumBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            MediumBtn.CheckedState.BorderThickness = 0;
            MediumBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            MediumBtn.CheckedState.InnerColor = Color.White;
            MediumBtn.CheckedState.InnerOffset = -4;
            MediumBtn.Location = new Point(26, 128);
            MediumBtn.Name = "MediumBtn";
            MediumBtn.Size = new Size(192, 26);
            MediumBtn.TabIndex = 10;
            MediumBtn.Text = "Средний (8–15 цветов)";
            MediumBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            MediumBtn.UncheckedState.BorderThickness = 2;
            MediumBtn.UncheckedState.FillColor = Color.Transparent;
            MediumBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // SmallBtn
            // 
            SmallBtn.AutoSize = true;
            SmallBtn.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SmallBtn.CheckedState.BorderThickness = 0;
            SmallBtn.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SmallBtn.CheckedState.InnerColor = Color.White;
            SmallBtn.CheckedState.InnerOffset = -4;
            SmallBtn.Location = new Point(26, 74);
            SmallBtn.Name = "SmallBtn";
            SmallBtn.Size = new Size(211, 26);
            SmallBtn.TabIndex = 9;
            SmallBtn.Text = "Маленький (до 7 цветов)";
            SmallBtn.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SmallBtn.UncheckedState.BorderThickness = 2;
            SmallBtn.UncheckedState.FillColor = Color.Transparent;
            SmallBtn.UncheckedState.InnerColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(103, 11);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 8;
            label1.Text = "Выберите букет";
            // 
            // BilliDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BilliDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightPink;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BilliDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BilliDGV.ColumnHeadersHeight = 29;
            BilliDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BilliDGV.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BilliDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BilliDGV.GridColor = Color.FromArgb(231, 229, 255);
            BilliDGV.Location = new Point(548, 79);
            BilliDGV.Name = "BilliDGV";
            BilliDGV.RowHeadersVisible = false;
            BilliDGV.Size = new Size(708, 448);
            BilliDGV.TabIndex = 10;
            BilliDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BilliDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BilliDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BilliDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BilliDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BilliDGV.ThemeStyle.BackColor = Color.White;
            BilliDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BilliDGV.ThemeStyle.HeaderStyle.BackColor = Color.LightPink;
            BilliDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BilliDGV.ThemeStyle.HeaderStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BilliDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BilliDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BilliDGV.ThemeStyle.HeaderStyle.Height = 29;
            BilliDGV.ThemeStyle.ReadOnly = false;
            BilliDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BilliDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BilliDGV.ThemeStyle.RowsStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BilliDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BilliDGV.ThemeStyle.RowsStyle.Height = 25;
            BilliDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BilliDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column5
            // 
            Column5.HeaderText = "Id";
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.HeaderText = "Предмет";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Цена";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Сумма";
            Column4.Name = "Column4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Trebuchet MS", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.LightPink;
            label4.Location = new Point(1270, 21);
            label4.Name = "label4";
            label4.Size = new Size(26, 28);
            label4.TabIndex = 11;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Trebuchet MS", 14F);
            QtyTb.Location = new Point(261, 436);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(66, 29);
            QtyTb.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(244, 402);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 13;
            label3.Text = "Количество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(1110, 545);
            label5.Name = "label5";
            label5.Size = new Size(96, 22);
            label5.TabIndex = 15;
            label5.Text = "GrdTotalLbl";
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.PaleVioletRed;
            Logoutbtn.Cursor = Cursors.Hand;
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(141, 710);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(155, 37);
            Logoutbtn.TabIndex = 18;
            Logoutbtn.Text = "Выйти из аккаунта";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.LightPink;
            PrintBtn.Cursor = Cursors.Hand;
            PrintBtn.Font = new Font("Trebuchet MS", 14F);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(1060, 600);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(196, 39);
            PrintBtn.TabIndex = 19;
            PrintBtn.Text = "Показать заказ";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click_1;
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.LightPink;
            OrderBtn.Cursor = Cursors.Hand;
            OrderBtn.Font = new Font("Trebuchet MS", 14F);
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(198, 488);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(196, 39);
            OrderBtn.TabIndex = 20;
            OrderBtn.Text = "Выбрать";
            OrderBtn.UseVisualStyleBackColor = false;
            OrderBtn.Click += OrderBtn_Click_1;
            // 
            // SettingBtn
            // 
            SettingBtn.BackColor = Color.Crimson;
            SettingBtn.Cursor = Cursors.Hand;
            SettingBtn.Font = new Font("Trebuchet MS", 14F);
            SettingBtn.ForeColor = Color.White;
            SettingBtn.Location = new Point(141, 600);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.Size = new Size(196, 39);
            SettingBtn.TabIndex = 21;
            SettingBtn.Text = "Назначить цены";
            SettingBtn.UseVisualStyleBackColor = false;
            SettingBtn.Click += SettingBtn_Click_1;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 787);
            Controls.Add(SettingBtn);
            Controls.Add(OrderBtn);
            Controls.Add(PrintBtn);
            Controls.Add(Logoutbtn);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(QtyTb);
            Controls.Add(label4);
            Controls.Add(BilliDGV);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BilliDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2RadioButton SmallBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton LargeBtn;
        private Guna.UI2.WinForms.Guna2RadioButton MediumBtn;
        private Guna.UI2.WinForms.Guna2DataGridView BilliDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 OrderBtn1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label3;
        private TextBox QtyTb;
        private Label label4;
        private Label label5;
        private Button Logoutbtn;
        private Button PrintBtn;
        private Button OrderBtn;
        private Button SettingBtn;
    }
}