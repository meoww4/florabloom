using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace florabloom
{
    public partial class AddProductForm : Form
    {
        private string imagePath = "";
        private Form parentForm;
        private string userRole;

        public AddProductForm(Form parent, string role)
        {
            InitializeComponent();
            parentForm = parent;
            this.userRole = role;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Выберите изображение";
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagePath = dlg.FileName;
                flowerPic.Image = Image.FromFile(imagePath);
                flowerPic.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText) || flowerPic.Image == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите изображение.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Цена должна быть числом.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mariia\Desktop\florabloom-master\FloraBloomBd.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO CatalogTb (Title, Price, ImagePath) VALUES (@title, @price, @imagePath)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", name);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@imagePath", imagePath);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Товар успешно добавлен!");
                this.Close();  // Закрываем форму после успешного добавления
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();
        }



        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
