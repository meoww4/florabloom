using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace florabloom
{
    public partial class Login : Form
    {
        private bool isDragging;
        private Point dragStart;
        private Functions Con;


        public Login()
        {
            InitializeComponent();
            Con = new Functions();

            // Позволяет форме перехватывать нажатия клавиш до контролов
            this.KeyPreview = true;

            UnameTb.KeyDown += LoginFields_KeyDown;
            PasswordTb.KeyDown += LoginFields_KeyDown;

            // Установим начальную картинку глазика
            eyeIcon.Image = LoadBitmapFromResource("florabloom.icon_eye.eye_closed.png");

            PasswordTb.PasswordChar = '●';
        }

        // Загрузка Bitmap из embedded ресурса по полному имени
        private Bitmap LoadBitmapFromResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
                throw new Exception($"Ресурс {resourceName} не найден. Проверьте имя и Build Action.");
            return new Bitmap(stream);
        }

        private void LoginFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                LoginBtn_Click_1(LoginBtn, EventArgs.Empty);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UnameTb.Text) || string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT PasswordHash, Role FROM Users WHERE Username = '{UnameTb.Text}'";
            DataTable dt = Con.GetData(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string storedHash = dt.Rows[0]["PasswordHash"].ToString();
            string role = dt.Rows[0]["Role"].ToString();

            if (BCrypt.Net.BCrypt.Verify(PasswordTb.Text, storedHash))
            {
                Billing Obj = new Billing(role);
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
{
    this.Hide();  // Скрыть окно входа

    using (var registerForm = new RegisterForm())
    {
        registerForm.ShowDialog();  // Открыть окно регистрации модально
    }

    this.Show();  // После закрытия регистрации показать окно входа снова
}

       

        private void RegisterCancelBtn_Click(object sender, EventArgs e)
        {
         
            LoginBtn.Enabled = true;
            RegisterBtn.Enabled = true;
         
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool isPasswordVisible = false;

        private void EyeIcon_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            PasswordTb.PasswordChar = isPasswordVisible ? '\0' : '●';

            eyeIcon.Image = isPasswordVisible
                ? LoadBitmapFromResource("florabloom.icon_eye.eye_open.png")
                : LoadBitmapFromResource("florabloom.icon_eye.eye_closed.png");
        }
    }
}