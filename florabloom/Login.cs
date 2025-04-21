namespace florabloom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Неправильный ввод!");
            }
            else if (UnameTb.Text == "user" && PasswordTb.Text == "pass")
            {
                Billing Obj = new Billing("admin");
                Obj.Show();
                this.Hide();
            }
            else if (UnameTb.Text == "anna" && PasswordTb.Text == "1234")
            {
                Billing Obj = new Billing("user");
                Obj.Show();
                this.Hide();
            }
            else if (UnameTb.Text == "max" && PasswordTb.Text == "qwerty")
            {
                Billing Obj = new Billing("user");
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
