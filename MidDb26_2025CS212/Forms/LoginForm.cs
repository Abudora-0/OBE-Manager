using System;
using System.Windows.Forms;

namespace MidDb26_2025CS212.Forms
{
    public partial class LoginForm : Form
    {
        // Hardcoded credentials
        private const string ADMIN_USERNAME = "admin";
        private const string ADMIN_PASSWORD = "admin123";

        public bool LoginSuccessful { get; private set; }
            = false;

        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Allow pressing Enter to login
            this.AcceptButton = btn_Login;
            txt_Username.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

            // Validate empty fields
            if (string.IsNullOrWhiteSpace(username))
            {
                lbl_error.Text = "Please enter your username.";
                txt_Username.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                lbl_error.Text = "Please enter your password.";
                txt_Password.Focus();
                return;
            }

            // Check credentials
            if (username == ADMIN_USERNAME &&
                password == ADMIN_PASSWORD)
            {
                LoginSuccessful = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbl_error.Text =
                    "Invalid username or password!";
                txt_Password.Clear();
                txt_Password.Focus();

                // Shake effect on error
                ShakeForm();
            }
        }

        private void ShakeForm()
        {
            int originalX = this.Location.X;
            for (int i = 0; i < 6; i++)
            {
                System.Threading.Thread.Sleep(30);
                this.Location = new System.Drawing.Point(
                    originalX + (i % 2 == 0 ? -8 : 8),
                    this.Location.Y);
                Application.DoEvents();
            }
            this.Location = new System.Drawing.Point(
                originalX, this.Location.Y);
        }
    }
}