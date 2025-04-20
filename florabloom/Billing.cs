using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        public Billing(string role)
        {
            InitializeComponent();
            Con = new Functions();
            Role = role;

            // Скрытие кнопки настроек для обычных пользователей
            if (Role != "admin")
            {
                SettingBtn.Visible = false; // Название кнопки настроек
            }
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
            /*printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }

        private void SettingBtn_Click_1(object sender, EventArgs e)
        {
            Settings Obj = new Settings(this);
            Obj.Show();
            this.Hide();
        }

        int Key = 0;
        int Price = 0;

        private void GetPrice(int Key)
        {
            string Flower = "";
            if (Key == 1) Flower = "Small";
            else if (Key == 2) Flower = "Medium";
            else if (Key == 3) Flower = "Large";

            string Query = $"select * from FlowerTb where Item = '{Flower}'";
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
        }

        int n = 0;
        string Items;

        private void OrderBtn_Click_1(object sender, EventArgs e)
        {
            if (SmallBtn.Checked) { Key = 1; Items = "Маленький букет"; }
            else if (MediumBtn.Checked) { Key = 2; Items = "Средний букет"; }
            else if (LargeBtn.Checked) { Key = 3; Items = "Большой букет"; }

            GetPrice(Key);

            int Qty = Convert.ToInt32(QtyTb.Text);
            int total = Qty * Price;

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BilliDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;

            BilliDGV.Rows.Add(newRow);
            n++;
        }

        private void SetPricebtn_Click(object sender, EventArgs e)
        {
            // пустой пока, можно добавить реализацию позже
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
