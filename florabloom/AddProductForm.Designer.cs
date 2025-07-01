namespace florabloom
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblImage = new Label();
            flowerPic = new PictureBox();
            btnBrowse = new Button();
            btnSave = new Button();
            Backbt = new Label();
            ((System.ComponentModel.ISupportInitialize)flowerPic).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(131, 22);
            lblName.TabIndex = 0;
            lblName.Text = "Название букета";
            // 
            // txtName
            // 
            txtName.Location = new Point(239, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 26);
            txtName.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 80);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 22);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Цена";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(239, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 26);
            txtPrice.TabIndex = 3;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(30, 130);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(175, 22);
            lblImage.TabIndex = 4;
            lblImage.Text = "Загрузка изображения";
            // 
            // flowerPic
            // 
            flowerPic.BorderStyle = BorderStyle.FixedSingle;
            flowerPic.Location = new Point(239, 175);
            flowerPic.Name = "flowerPic";
            flowerPic.Size = new Size(250, 200);
            flowerPic.SizeMode = PictureBoxSizeMode.StretchImage;
            flowerPic.TabIndex = 5;
            flowerPic.TabStop = false;
            flowerPic.Visible = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(239, 130);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 30);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Выбрать...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightPink;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(389, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Backbt
            // 
            Backbt.AutoSize = true;
            Backbt.Cursor = Cursors.Hand;
            Backbt.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            Backbt.ForeColor = Color.LightPink;
            Backbt.Location = new Point(44, 397);
            Backbt.Name = "Backbt";
            Backbt.Size = new Size(64, 24);
            Backbt.TabIndex = 11;
            Backbt.Text = "Назад";
            Backbt.Click += Backbt_Click;
            // 
            // AddProductForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(542, 460);
            Controls.Add(Backbt);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblImage);
            Controls.Add(flowerPic);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Font = new Font("Trebuchet MS", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить товар";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)flowerPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblImage;
        private PictureBox flowerPic;
        private Button btnBrowse;
        private Button btnSave;
        private Label Backbt;
    }
}
