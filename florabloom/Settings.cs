using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace florabloom
{
    public partial class Settings : Form
    {
        Functions Con;
        Form previousForm;

        public Settings(Form callingForm)
        {
            InitializeComponent();
            Con = new Functions();
            previousForm = callingForm;
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Настройки_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click_1(object sender, EventArgs e)
        {
            string Key;
            try
            {

                int Pr = Convert.ToInt32(PriceTb.Text);



                if (FlowerCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Пожалуйста, выберите букет!");
                }
                else if (FlowerCb.SelectedIndex == 0)
                {
                    Key = "Large";
                    string Query = "Update FlowerTb set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Цена обновлена!");
                }
                else if (FlowerCb.SelectedIndex == 1)
                {
                    Key = "Medium";
                    string Query = "Update FlowerTb set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Цена обновлена!");
                }
                else if (FlowerCb.SelectedIndex == 2) // Исправлено с 1 на 2
                {
                    Key = "Small";
                    string Query = "Update FlowerTb set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Цена обновлена!");
                }
            }


            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void PriceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }




        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
