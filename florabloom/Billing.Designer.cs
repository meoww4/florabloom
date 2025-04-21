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
            priceLbl = new Label();
            flowerPic = new PictureBox();
            comboCatalog = new ComboBox();
            BilliDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            Logoutbtn = new Button();
            OrderBtn = new Button();
            SettingBtn = new Button();
            totalLbl = new Label();
            confirmBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flowerPic).BeginInit();
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
            panel2.Controls.Add(priceLbl);
            panel2.Controls.Add(flowerPic);
            panel2.Controls.Add(comboCatalog);
            panel2.Location = new Point(119, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 409);
            panel2.TabIndex = 7;
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(14, 351);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(52, 22);
            priceLbl.TabIndex = 23;
            priceLbl.Text = "label5";
            // 
            // flowerPic
            // 
            flowerPic.Location = new Point(14, 72);
            flowerPic.Name = "flowerPic";
            flowerPic.Size = new Size(312, 267);
            flowerPic.SizeMode = PictureBoxSizeMode.StretchImage;
            flowerPic.TabIndex = 22;
            flowerPic.TabStop = false;
            flowerPic.Click += flowerPic_Click;
            // 
            // comboCatalog
            // 
            comboCatalog.FormattingEnabled = true;
            comboCatalog.Items.AddRange(new object[] { "Большой (15+ цветов)", "Средний (8–15 цветов)", "Маленький (до 7 цветов)" });
            comboCatalog.Location = new Point(14, 16);
            comboCatalog.Name = "comboCatalog";
            comboCatalog.Size = new Size(212, 30);
            comboCatalog.TabIndex = 12;
            comboCatalog.SelectedIndexChanged += comboCatalog_SelectedIndexChanged_1;
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
            BilliDGV.Location = new Point(557, 79);
            BilliDGV.Name = "BilliDGV";
            BilliDGV.RowHeadersVisible = false;
            BilliDGV.Size = new Size(704, 448);
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
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.PaleVioletRed;
            Logoutbtn.Cursor = Cursors.Hand;
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(119, 710);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(155, 37);
            Logoutbtn.TabIndex = 18;
            Logoutbtn.Text = "Выйти из аккаунта";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.LightPink;
            OrderBtn.Cursor = Cursors.Hand;
            OrderBtn.Font = new Font("Trebuchet MS", 14F);
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(119, 503);
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
            SettingBtn.Location = new Point(119, 601);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.Size = new Size(196, 39);
            SettingBtn.TabIndex = 21;
            SettingBtn.Text = "Назначить цены";
            SettingBtn.UseVisualStyleBackColor = false;
            SettingBtn.Click += SettingBtn_Click_1;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(557, 550);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(52, 22);
            totalLbl.TabIndex = 24;
            totalLbl.Text = "label5";
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.LightPink;
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.Font = new Font("Trebuchet MS", 14F);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(1065, 550);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(196, 39);
            confirmBtn.TabIndex = 25;
            confirmBtn.Text = "Заказать";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click_1;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 787);
            Controls.Add(confirmBtn);
            Controls.Add(totalLbl);
            Controls.Add(SettingBtn);
            Controls.Add(OrderBtn);
            Controls.Add(Logoutbtn);
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
            ((System.ComponentModel.ISupportInitialize)flowerPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)BilliDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView BilliDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 OrderBtn1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label4;
        private Button Logoutbtn;
        private Button OrderBtn;
        private Button SettingBtn;
        private ComboBox comboCatalog;
        private PictureBox flowerPic;
        private Label priceLbl;
        private Label totalLbl;
        private Button confirmBtn;
    }
}