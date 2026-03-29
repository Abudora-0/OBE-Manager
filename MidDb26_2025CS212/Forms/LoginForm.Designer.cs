namespace MidDb26_2025CS212.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.lbl_appsub = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_signin = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_hint = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ── LEFT PANEL ─────────────────────────────────
            this.pnl_left.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_left.Location =
                new System.Drawing.Point(0, 0);
            this.pnl_left.Size =
                new System.Drawing.Size(340, 500);
            this.pnl_left.Controls.Add(this.lbl_appname);
            this.pnl_left.Controls.Add(this.lbl_appsub);
            this.pnl_left.Controls.Add(this.lbl_desc);

            this.pic_Logo.Location =
            new System.Drawing.Point(85, 40);
            this.pic_Logo.Size =
                new System.Drawing.Size(120, 120);
            this.pic_Logo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.BackColor =
                System.Drawing.Color.Transparent;
            try
            {
                this.pic_Logo.Image = System.Drawing.Image.FromFile(
                    "uet logo.png");
            }
            catch { }

            this.pnl_left.Controls.Add(this.pic_Logo);

            this.lbl_appname.Text = "OBE Manager";
            this.lbl_appname.ForeColor =
                System.Drawing.Color.White;
            this.lbl_appname.Font = new System.Drawing.Font(
                "Segoe UI", 26F,
                System.Drawing.FontStyle.Bold);
            this.lbl_appname.Location =
                new System.Drawing.Point(23, 170);
            this.lbl_appname.Size =
                new System.Drawing.Size(280, 50);

            this.lbl_appsub.Text =
                "CS104 · Database Systems";
            this.lbl_appsub.ForeColor =
                System.Drawing.Color.FromArgb(160, 180, 230);
            this.lbl_appsub.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.lbl_appsub.Location =
                new System.Drawing.Point(30, 216);
            this.lbl_appsub.Size =
                new System.Drawing.Size(280, 24);

            this.lbl_desc.Text =
                "Outcome Based Education\r\n" +
                "Management System\r\n\r\n" +
                "· Manage Students & CLOs\r\n" +
                "· Track Evaluations\r\n" +
                "· Generate PDF Reports\r\n" +
                "· Monitor Attendance";
            this.lbl_desc.ForeColor =
                System.Drawing.Color.FromArgb(120, 140, 200);
            this.lbl_desc.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.lbl_desc.Location =
                new System.Drawing.Point(30, 260);
            this.lbl_desc.Size =
                new System.Drawing.Size(280, 160);

            // ── RIGHT PANEL ────────────────────────────────
            this.pnl_right.BackColor =
                System.Drawing.Color.White;
            this.pnl_right.Location =
                new System.Drawing.Point(340, 0);
            this.pnl_right.Size =
                new System.Drawing.Size(360, 500);
            this.pnl_right.Controls.Add(this.lbl_welcome);
            this.pnl_right.Controls.Add(this.lbl_signin);
            this.pnl_right.Controls.Add(this.lbl_user);
            this.pnl_right.Controls.Add(this.txt_Username);
            this.pnl_right.Controls.Add(this.lbl_pass);
            this.pnl_right.Controls.Add(this.txt_Password);
            this.pnl_right.Controls.Add(this.btn_Login);
            this.pnl_right.Controls.Add(this.lbl_error);
            this.pnl_right.Controls.Add(this.lbl_hint);

            this.lbl_welcome.Text = "Welcome Back!";
            this.lbl_welcome.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_welcome.Font = new System.Drawing.Font(
                "Segoe UI", 20F,
                System.Drawing.FontStyle.Bold);
            this.lbl_welcome.Location =
                new System.Drawing.Point(30, 80);
            this.lbl_welcome.Size =
                new System.Drawing.Size(300, 40);

            this.lbl_signin.Text =
                "Sign in to your account";
            this.lbl_signin.ForeColor =
                System.Drawing.Color.FromArgb(150, 150, 150);
            this.lbl_signin.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.lbl_signin.Location =
                new System.Drawing.Point(30, 124);
            this.lbl_signin.Size =
                new System.Drawing.Size(300, 22);

            // Username
            this.lbl_user.Text = "USERNAME";
            this.lbl_user.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_user.Font = new System.Drawing.Font(
                "Segoe UI", 8F,
                System.Drawing.FontStyle.Bold);
            this.lbl_user.Location =
                new System.Drawing.Point(30, 180);
            this.lbl_user.Size =
                new System.Drawing.Size(300, 16);

            this.txt_Username.Location =
                new System.Drawing.Point(30, 200);
            this.txt_Username.Size =
                new System.Drawing.Size(300, 32);
            this.txt_Username.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.txt_Username.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            // Password
            this.lbl_pass.Text = "PASSWORD";
            this.lbl_pass.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_pass.Font = new System.Drawing.Font(
                "Segoe UI", 8F,
                System.Drawing.FontStyle.Bold);
            this.lbl_pass.Location =
                new System.Drawing.Point(30, 254);
            this.lbl_pass.Size =
                new System.Drawing.Size(300, 16);

            this.txt_Password.Location =
                new System.Drawing.Point(30, 274);
            this.txt_Password.Size =
                new System.Drawing.Size(300, 32);
            this.txt_Password.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.txt_Password.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.PasswordChar = '●';

            // Login button
            this.btn_Login.Text = "Sign In";
            this.btn_Login.Location =
                new System.Drawing.Point(30, 336);
            this.btn_Login.Size =
                new System.Drawing.Size(300, 44);
            this.btn_Login.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.btn_Login.ForeColor =
                System.Drawing.Color.White;
            this.btn_Login.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.Font = new System.Drawing.Font(
                "Segoe UI", 12F,
                System.Drawing.FontStyle.Bold);
            this.btn_Login.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Click +=
                new System.EventHandler(
                this.btn_Login_Click);

            // Error label
            this.lbl_error.Text = "";
            this.lbl_error.ForeColor =
                System.Drawing.Color.FromArgb(183, 28, 28);
            this.lbl_error.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lbl_error.Location =
                new System.Drawing.Point(30, 390);
            this.lbl_error.Size =
                new System.Drawing.Size(300, 20);
            this.lbl_error.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Hint label
            this.lbl_hint.Text =
                "Hint: admin / admin123";
            this.lbl_hint.ForeColor =
                System.Drawing.Color.FromArgb(200, 200, 200);
            this.lbl_hint.Font = new System.Drawing.Font(
                "Segoe UI", 8F);
            this.lbl_hint.Location =
                new System.Drawing.Point(30, 460);
            this.lbl_hint.Size =
                new System.Drawing.Size(300, 20);
            this.lbl_hint.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ── MAIN FORM ──────────────────────────────────
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_right);
            this.Text = "OBE Manager — Login";
            this.Size = new System.Drawing.Size(700, 500);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition
                .CenterScreen;
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle
                .FixedSingle;
            this.MaximizeBox = false;
            this.BackColor =
                System.Drawing.Color.White;

            this.ResumeLayout(false);
        }

        // Control declarations
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Label lbl_appsub;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_signin;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_hint;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}