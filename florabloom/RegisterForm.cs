using System;
using System.Data;
using System.Windows.Forms;

namespace florabloom
{
    public partial class RegisterForm : Form
    {
        private Functions Con;

        public RegisterForm()
        {
            InitializeComponent();
            Con = new Functions();

            MasterPasswordTb.Visible = false;
            MasterPasswordLbl.Visible = false;

            RegisterRoleCb.SelectedIndexChanged += (s, e) =>
            {
                bool isAdmin = RegisterRoleCb.SelectedItem?.ToString() == "admin";
                MasterPasswordTb.Visible = isAdmin;
                MasterPasswordLbl.Visible = isAdmin;
            };
        }

        private void RegisterConfirmBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegisterUnameTb.Text) || string.IsNullOrWhiteSpace(RegisterPasswordTb.Text) || RegisterRoleCb.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = RegisterUnameTb.Text;
            string password = RegisterPasswordTb.Text;
            string role = RegisterRoleCb.SelectedItem.ToString();
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            if (role == "admin")
            {
                if (string.IsNullOrWhiteSpace(MasterPasswordTb.Text))
                {
                    MessageBox.Show("Введите мастер-пароль для регистрации администратора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT PasswordHash FROM Users WHERE Username = 'admin'";
                DataTable dt = Con.GetData(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Главный администратор не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string adminHash = dt.Rows[0]["PasswordHash"].ToString();
                if (!BCrypt.Net.BCrypt.Verify(MasterPasswordTb.Text, adminHash))
                {
                    MessageBox.Show("Неверный мастер-пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                string query = $"INSERT INTO Users (Username, PasswordHash, Role) VALUES ('{username}', '{passwordHash}', '{role}')";
                Con.setData(query);
                MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterUnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
