using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace florabloom
{
    public partial class Billing : Form
    {
        Functions Con;
        private string Role; 
        int n = 0;
        int Price = 0;

        private Button AddProductBtn;
        private Dictionary<int, int> _orderItems = new Dictionary<int, int>();

        public Billing(string role)
        {
            InitializeComponent();
            this.Role = role;

            Con = new Functions();

            BilliDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BilliDGV.MultiSelect = false;
            BilliDGV.ClearSelection();
            BilliDGV.CellClick += BilliDGV_CellClick;

            if (Role != "admin")
            {
                SettingBtn.Visible = false;
            }

            if (!BilliDGV.Columns.Contains("BouquetId"))
            {
                DataGridViewTextBoxColumn bouquetIdColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "BouquetId",
                    Name = "BouquetId",
                    Visible = false
                };
                BilliDGV.Columns.Add(bouquetIdColumn);
            }

            if (Role == "admin")
            {
                CreateAddProductBtn();
            }

            LoadBouquets();

            comboCatalog.SelectedIndexChanged += comboCatalog_SelectedIndexChanged;
            priceLbl.Text = " ";
            totalLbl.Text = "Общая сумма: 0 ₽";
            comboCatalog.SelectedItem = null;

            BilliDGV.ReadOnly = Role == "user";
        }

        private void CreateAddProductBtn()
        {
            AddProductBtn = new Button();
            AddProductBtn.BackColor = Color.MediumSeaGreen;
            AddProductBtn.Cursor = Cursors.Hand;
            AddProductBtn.Font = new Font("Trebuchet MS", 14F);
            AddProductBtn.ForeColor = Color.White;
            AddProductBtn.Location = new Point(119, 659);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(226, 39);
            AddProductBtn.TabIndex = 28;
            AddProductBtn.Text = "Добавить товар";
            AddProductBtn.UseVisualStyleBackColor = false;
            Controls.Add(AddProductBtn);
            AddProductBtn.Click += btnAddProduct_Click;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm(this, Role);
            addForm.Show();
            this.Hide();
        }

        private bool IsUserAdmin()
        {
            return Role == "admin";
        }

        private void LoadBouquets()
        {
            string query = "SELECT Id, Title, Price, ImagePath FROM CatalogTb";
            DataTable dt = Con.GetData(query);

            comboCatalog.DisplayMember = "Title";
            comboCatalog.ValueMember = "Id";
            comboCatalog.DataSource = dt;
        }

        private void comboCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCatalog.SelectedItem is DataRowView row)
            {
                Price = Convert.ToInt32(row["Price"]);
                string imgPath = row["ImagePath"].ToString();

                priceLbl.Text = $"Цена: {Price} ₽";

                string fullPath = Path.Combine(Application.StartupPath, imgPath);
                if (File.Exists(fullPath))
                    flowerPic.Image = Image.FromFile(fullPath);
                else
                    flowerPic.Image = null;
            }
            else
            {
                priceLbl.Text = " ";
                flowerPic.Image = null;
            }
        }


        private void OrderBtn_Click_1(object sender, EventArgs e)
        {
            if (comboCatalog.SelectedItem is DataRowView row)
            {
                int bouquetId = Convert.ToInt32(row["Id"]);
                string bouquetTitle = row["Title"].ToString();
                int bouquetPrice = Convert.ToInt32(row["Price"]);

                if (_orderItems.ContainsKey(bouquetId))
                    _orderItems[bouquetId]++;
                else
                    _orderItems[bouquetId] = 1;

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BilliDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = bouquetTitle;
                newRow.Cells[2].Value = bouquetPrice;
                newRow.Cells[3].Value = bouquetId;

                BilliDGV.Rows.Add(newRow);
                n++;

                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите букет из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTotalAmount()
        {
            int totalAmount = 0;

            foreach (DataGridViewRow row in BilliDGV.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    totalAmount += Convert.ToInt32(row.Cells[2].Value);
                }
            }

            totalLbl.Text = $"Общая сумма: {totalAmount} ₽";
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (BilliDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите позицию для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = BilliDGV.SelectedRows[0]; // выделенная строка
            int bouquetId = Convert.ToInt32(selectedRow.Cells["BouquetId"].Value); // или индекс столбца с ID

            if (_orderItems.ContainsKey(bouquetId))
            {
                _orderItems[bouquetId]--;
                if (_orderItems[bouquetId] <= 0)
                    _orderItems.Remove(bouquetId);

                BilliDGV.Rows.Remove(selectedRow);

                // Обновляем нумерацию строк
                for (int i = 0; i < BilliDGV.Rows.Count; i++)
                {
                    BilliDGV.Rows[i].Cells[0].Value = i + 1;
                }

                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Ошибка: выбранный букет не найден в заказе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            if (_orderItems.Count == 0)
            {
                MessageBox.Show("Пожалуйста, добавьте хотя бы один букет в заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var msg = MessageBox.Show("Вы точно уверены, что хотите оформить заказ?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (msg != DialogResult.Yes)
                return;

            this.Hide();
            new Order(_orderItems).ShowDialog();
            this.Show();

            BilliDGV.Rows.Clear();
            _orderItems.Clear();
            totalLbl.Text = "Общая сумма: 0 ₽";
            n = 0;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void SettingBtn_Click_1(object sender, EventArgs e)
        {
            Settings Obj = new Settings(Role);
            Obj.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowerPic_Click(object sender, EventArgs e)
        {
            
        }

        private void comboCatalog_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboCatalog_SelectedIndexChanged(sender, e);
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }
        private void BilliDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BilliDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BilliDGV.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
