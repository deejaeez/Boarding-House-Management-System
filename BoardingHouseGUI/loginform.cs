using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoardingHouseGUI
{
    class LoginForm : Form
    {
        TextBox txtUser = new TextBox();
        TextBox txtPass = new TextBox();

        public LoginForm()
        {
            Text = "Boarding House Management System";
            ClientSize = new Size(600, 600);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = Color.White;
            Font = new Font("Georgia", 10);

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                BackColor = Color.FromArgb(58, 90, 64)
            };
            header.Controls.Add(new Label
            {
                Text = "BOARDING HOUSE\nMANAGEMENT SYSTEM",
                ForeColor = Color.White,
                Font = new Font("Georgia", 16, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            });

            int w = 320;
            Panel box = new Panel { Size = new Size(w, 260) };

            Label sub = new Label
            {
                Text = "Admin Login",
                Font = new Font("Georgia", 15, FontStyle.Bold),
                ForeColor = Color.FromArgb(58, 90, 64),
                Location = new Point(0, 0),
                Size = new Size(w, 30),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblUser = new Label
            {
                Text = "Username",
                Location = new Point(0, 55),
                Size = new Size(w, 25),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };
            txtUser.Location = new Point(0, 85);
            txtUser.Width = w;
            txtUser.TextAlign = HorizontalAlignment.Center;

            Label lblPass = new Label
            {
                Text = "Password",
                Location = new Point(0, 130),
                Size = new Size(w, 25),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };
            txtPass.Location = new Point(0, 160);
            txtPass.Width = w;
            txtPass.TextAlign = HorizontalAlignment.Center;
            txtPass.UseSystemPasswordChar = true;

            Button btnLogin = new Button
            {
                Text = "LOGIN",
                Location = new Point(0, 218),
                Size = new Size(w, 42),
                BackColor = Color.FromArgb(58, 90, 64),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
                btnLogin.FlatAppearance.BorderSize = 0;
                btnLogin.Click += BtnLogin_Click;
                AcceptButton = btnLogin;

                box.Controls.AddRange(new Control[] { sub, lblUser, txtUser, lblPass, txtPass, btnLogin });

            void CenterBox()
            {
                int freeHeight = ClientSize.Height - header.Height;
                box.Location = new Point(
                    (ClientSize.Width - box.Width) / 2,
                    header.Height + (freeHeight - box.Height) / 2);
            }
            CenterBox();

            Controls.AddRange(new Control[] { header, box });
        }
        void BtnLogin_Click(object? sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                Hide();
                DashboardForm dash = new DashboardForm();
                dash.FormClosed += (s, args) => Close();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }
        }
    }
}