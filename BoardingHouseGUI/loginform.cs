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
            ClientSize = new Size(450, 400);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = Color.FromArgb(218, 215, 205);
            Font = new Font("Georgia", 10);

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                BackColor = Color.FromArgb(20, 60, 40)
            };

            header.Controls.Add(new Label
            {
                Text = "MGQ Boarding House",
                ForeColor = Color.FromArgb(218, 215, 205),
                Font = new Font("Georgia", 16, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            });

            // ---------- LOGIN BOX ----------
            int w = 300;

            Panel box = new Panel
            {
                Size = new Size(w, 260),
                Location = new Point(75, 140)
            };

            Label sub = new Label
            {
                Text = "Admin Login",
                Font = new Font("Georgia", 15, FontStyle.Bold),
                ForeColor = Color.FromArgb(20, 60, 40),
                Location = new Point(0, -5),
                Size = new Size(w, 30),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblUser = new Label
            {
                Text = "Username",
                Location = new Point(0, 40),
                Size = new Size(w, 25),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            txtUser.Location = new Point(0, 70);
            txtUser.Width = w;
            txtUser.TextAlign = HorizontalAlignment.Center;

            Label lblPass = new Label
            {
                Text = "Password",
                Location = new Point(0, 110),
                Size = new Size(w, 25),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            txtPass.Location = new Point(0, 140);
            txtPass.Width = w;
            txtPass.TextAlign = HorizontalAlignment.Center;
            txtPass.UseSystemPasswordChar = true;

            Button btnLogin = new Button
            {
                Text = "LOGIN",
                Location = new Point(0, 180),
                Size = new Size(w, 42),
                BackColor = Color.FromArgb(20, 60, 40),
                ForeColor = Color.FromArgb(218, 215, 205),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Georgia", 11, FontStyle.Bold),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };
<<<<<<< HEAD
                btnLogin.FlatAppearance.BorderSize = 0;
                btnLogin.Click += BtnLogin_Click;
=======
>>>>>>> 5df9ab1a3e8342452401c33f40140a3670bfdcda

            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;
            AcceptButton = btnLogin;

            box.Controls.AddRange(new Control[]
            {
                sub, lblUser, txtUser, lblPass, txtPass, btnLogin
            });

            Controls.Add(header);
            Controls.Add(box);
        }

        void BtnLogin_Click(object? sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                Hide();
<<<<<<< HEAD
                DashboardForm dash = new DashboardForm(); 
                dash.FormClosed += (s, args) => Close();    
=======

                DashboardForm dash = new DashboardForm();
                dash.FormClosed += (s, args) => Close();
>>>>>>> 5df9ab1a3e8342452401c33f40140a3670bfdcda
                dash.Show();
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }
        }
    }
}