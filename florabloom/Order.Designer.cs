    namespace florabloom
    {
        partial class Order
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            leftPanel = new Panel();
            backButton = new Button();
            label2 = new Label();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.LightPink;
            leftPanel.Controls.Add(backButton);
            leftPanel.Controls.Add(label2);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 660);
            leftPanel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.BackColor = Color.IndianRed;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(12, 603);
            backButton.Name = "backButton";
            backButton.Size = new Size(170, 45);
            backButton.TabIndex = 9;
            backButton.Text = "НАЗАД";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(149, 87);
            label2.TabIndex = 7;
            label2.Text = "ВАШ ЗАКАЗ \r\nУЖЕ ЕДЕТ \r\nК ВАМ!";
            // 
            // Order
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1029, 660);
            Controls.Add(leftPanel);
            Font = new Font("Trebuchet MS", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказ";
            Load += Order_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Button backButton;
        }
    }
