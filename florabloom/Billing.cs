using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace florabloom
{
    public partial class Billing : Form
    {
        Functions Con;
        string Role = "user"; // по умолчанию обычный пользователь
        int Key = 0;
        int Price = 0;
        int n = 0;
        string Items;

        public Billing(string role)
        {
            InitializeComponent();
            Con = new Functions();
            Role = role;

            // Скрытие кнопки настроек для обычных пользователей
            if (Role != "admin")
            {
                SettingBtn.Visible = false;
            }

            LoadBouquets();
            comboCatalog.SelectedIndexChanged += comboCatalog_SelectedIndexChanged;
            priceLbl.Text = " ";
            totalLbl.Text = "Общая сумма: 0 ₽";
            comboCatalog.SelectedItem = null;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintBtn_Click_1(object sender, EventArgs e)
        {
            /*
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            */
        }

        private void SettingBtn_Click_1(object sender, EventArgs e)
        {
            Settings Obj = new Settings(Role);
            Obj.Show();
            this.Close();
        }

        private void OrderBtn_Click_1(object sender, EventArgs e)
        {
            if (comboCatalog.SelectedItem is DataRowView row)
            {
                int bouquetId = Convert.ToInt32(row["Id"]);
                string bouquetTitle = row["Title"].ToString();
                int bouquetPrice = Convert.ToInt32(row["Price"]);

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BilliDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = bouquetTitle;
                newRow.Cells[2].Value = bouquetPrice;

                BilliDGV.Rows.Add(newRow);
                n++;

                UpdateTotalAmount(); // ← Обновляем сумму после добавления
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

        private void SetPricebtn_Click(object sender, EventArgs e)
        {
            // Пусто
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        // ---------- ДОБАВЛЕНО ДЛЯ COMBOBOX ----------

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
                string imgPath = row["ImagePath"].ToString(); // название поля из БД

                priceLbl.Text = $"Цена: {Price} ₽";

                string fullPath = Path.Combine(Application.StartupPath, imgPath);
                if (File.Exists(fullPath))
                    flowerPic.Image = Image.FromFile(fullPath);
                else
                    flowerPic.Image = null;
            }
        }

        private void comboCatalog_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void flowerPic_Click(object sender, EventArgs e)
        {
        }

        private void confirmBtn_Click_1(object sender, EventArgs e)
        {
            if (BilliDGV.Rows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, добавьте хотя бы один букет в заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Заказ успешно оформлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Дополнительно — можно очистить заказ:
            BilliDGV.Rows.Clear();
            totalLbl.Text = "Общая сумма: 0 ₽";
            n = 0;
        }

    }
}
