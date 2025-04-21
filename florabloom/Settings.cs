using System;
using System.Data;
using System.Windows.Forms;

namespace florabloom
{
    public partial class Settings : Form
    {
        Functions Con;
        string role;

        public Settings(string callingRole)
        {
            InitializeComponent();
            Con = new Functions();
            role = callingRole;
            LoadCatalogItems();
        }

        // Загрузка данных из таблицы CatalogTb
        private void LoadCatalogItems()
        {
            string query = "SELECT Id, Title FROM CatalogTb";
            DataTable dt = Con.GetData(query);

            FlowerCb.DisplayMember = "Title";
            FlowerCb.ValueMember = "Id";
            FlowerCb.DataSource = dt;
        }

        private void SubmitBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (FlowerCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Пожалуйста, выберите букет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(PriceTb.Text))
                {
                    MessageBox.Show("Пожалуйста, введите цену!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(PriceTb.Text, out int newPrice))
                {
                    MessageBox.Show("Цена должна быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedId = Convert.ToInt32(FlowerCb.SelectedValue);
                string query = $"UPDATE CatalogTb SET Price = {newPrice} WHERE Id = {selectedId}";
                Con.setData(query);

                MessageBox.Show("Цена обновлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Backbt_Click(object sender, EventArgs e)
        {
            /*  previousForm.Show();*/
            Billing billing = new Billing(role);
            billing.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
