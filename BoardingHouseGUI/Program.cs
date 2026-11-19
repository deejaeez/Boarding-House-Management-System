    using System;
    using System.Drawing;
    using System.Windows.Forms;

    namespace BoardingHouseGUI
    {
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.Run(new LoginForm());
            }
        }

        class LoginForm : Form
        {
            TextBox txtUser = new TextBox();
            TextBox txtPass = new TextBox();
            Label lblError = new Label();
            int attemptsLeft = 3;

            public LoginForm()
            {
                Text = "Boarding House Management System";
                ClientSize = new Size(420, 460);
                StartPosition = FormStartPosition.CenterScreen;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                MaximizeBox = false;
                BackColor = Color.White;
                Font = new Font("Georgia", 10);

                Panel header = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 120,
                    BackColor = Color.FromArgb(20, 83, 45)
                };
                Label title = new Label
                {
                    Text = "BOARDING HOUSE\nMANAGEMENT SYSTEM",
                    ForeColor = Color.White,
                    Font = new Font("Georgia", 16, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                header.Controls.Add(title);

                Label sub = new Label
                {
                    Text = "Admin Login",
                    Font = new Font("Georgia", 13, FontStyle.Bold),
                    ForeColor = Color.FromArgb(20, 83, 45),
                    Location = new Point(50, 150),
                    AutoSize = true
                };

                Label lblUser = new Label { Text = "Username", Location = new Point(50, 195), AutoSize = true };
                txtUser.Location = new Point(50, 220);
                txtUser.Width = 320;

                Label lblPass = new Label { Text = "Password", Location = new Point(50, 265), AutoSize = true };
                txtPass.Location = new Point(50, 290);
                txtPass.Width = 320;
                txtPass.UseSystemPasswordChar = true;

                CheckBox chkShow = new CheckBox { Text = "Show password", Location = new Point(50, 325), AutoSize = true };
                chkShow.CheckedChanged += (s, e) => txtPass.UseSystemPasswordChar = !chkShow.Checked;

                lblError.Location = new Point(50, 355);
                lblError.Size = new Size(320, 24);
                lblError.ForeColor = Color.Red;

                Button btnLogin = new Button
                {
                    Text = "LOGIN",
                    Location = new Point(50, 390),
                    Size = new Size(320, 42),
                    BackColor = Color.FromArgb(20, 83, 45),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnLogin.FlatAppearance.BorderSize = 0;
                btnLogin.Click += BtnLogin_Click;
                AcceptButton = btnLogin;

                Controls.AddRange(new Control[] { header, sub, lblUser, txtUser, lblPass, txtPass, chkShow, lblError, btnLogin });
            }

            void BtnLogin_Click(object? sender, EventArgs e)
            {
                if (txtUser.Text == "admin" && txtPass.Text == "1234")
                {
                    Hide();
                    DashboardForm dash = new DashboardForm();
                    dash.FormClosed += (s, args) => Close();
                    dash.Show();
                    return;
                }

                attemptsLeft--;
                if (attemptsLeft <= 0)
                {
                    MessageBox.Show("Too many failed attempts. The program will close.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                lblError.Text = $"Wrong login. Attempts left: {attemptsLeft}";
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        class DashboardForm : Form
        {
            public DashboardForm()
            {
                Text = "Boarding House Management System";
                Size = new Size(900, 550);
                StartPosition = FormStartPosition.CenterScreen;

                Label welcome = new Label
                {
                    Text = "WELKAMS",
                    Font = new Font("Georgia", 16),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                Controls.Add(welcome);
            }
        }
    }