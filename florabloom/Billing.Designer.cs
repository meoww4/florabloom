namespace florabloom
{
    partial class Billing
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            priceLbl = new Label();
            flowerPic = new PictureBox();
            comboCatalog = new ComboBox();
            BilliDGV = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            BoqPrice = new DataGridViewTextBoxColumn();
            Logoutbtn = new Button();
            OrderBtn = new Button();
            SettingBtn = new Button();
            totalLbl = new Label();
            confirmBtn = new Button();
            label1 = new Label();
            RemoveBtn = new Button();
            AddProductBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flowerPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BilliDGV).BeginInit();
            SuspendLayout();
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
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(133, 9);
            label2.Name = "label2";
            label2.Size = new Size(128, 24);
            label2.TabIndex = 6;
            label2.Text = "FlowerBloom";
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
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BilliDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BilliDGV.ColumnHeadersHeight = 29;
            BilliDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Title, BoqPrice });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BilliDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BilliDGV.GridColor = Color.FromArgb(231, 229, 255);
            BilliDGV.Location = new Point(557, 79);
            BilliDGV.Name = "BilliDGV";
            BilliDGV.ReadOnly = true;
            BilliDGV.RowHeadersVisible = false;
            BilliDGV.RowHeadersWidth = 51;
            BilliDGV.Size = new Size(704, 448);
            BilliDGV.TabIndex = 10;
            BilliDGV.CellContentClick += BilliDGV_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Предмет";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 300;
            // 
            // BoqPrice
            // 
            BoqPrice.HeaderText = "Цена";
            BoqPrice.MinimumWidth = 6;
            BoqPrice.Name = "BoqPrice";
            BoqPrice.ReadOnly = true;
            BoqPrice.Width = 301;
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
            SettingBtn.Size = new Size(226, 39);
            SettingBtn.TabIndex = 21;
            SettingBtn.Text = "Редактировать цены";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(133, 33);
            label1.Name = "label1";
            label1.Size = new Size(568, 18);
            label1.TabIndex = 26;
            label1.Text = "Доставляем радость в каждом букете — с любовью, заботой и вниманием к деталям!";
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.LightPink;
            RemoveBtn.Cursor = Cursors.Hand;
            RemoveBtn.Font = new Font("Trebuchet MS", 14F);
            RemoveBtn.ForeColor = Color.White;
            RemoveBtn.Location = new Point(799, 550);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(196, 39);
            RemoveBtn.TabIndex = 27;
            RemoveBtn.Text = "Удалить";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(0, 0);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(75, 23);
            AddProductBtn.TabIndex = 28;
            // 
            // Billing
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1308, 787);
            Controls.Add(RemoveBtn);
            Controls.Add(label1);
            Controls.Add(confirmBtn);
            Controls.Add(totalLbl);
            Controls.Add(SettingBtn);
            Controls.Add(OrderBtn);
            Controls.Add(Logoutbtn);
            Controls.Add(BilliDGV);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(AddProductBtn);
            Font = new Font("Trebuchet MS", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оформление заказа";
            Load += Billing_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flowerPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)BilliDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.PictureBox flowerPic;
        private System.Windows.Forms.ComboBox comboCatalog;
        private System.Windows.Forms.DataGridView BilliDGV;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn BoqPrice;
    }
}
