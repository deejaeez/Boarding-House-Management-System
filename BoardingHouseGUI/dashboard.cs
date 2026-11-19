using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoardingHouseGUI
{
    public class DashboardForm : Form
    {
        public DashboardForm()
        {
            Text = "Boarding House Management System";
            Size = new Size(1000, 650);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;

            Label welcome = new Label
            {
                Text = "WELKAM",
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ForeColor = Color.FromArgb(20, 83, 45),
                AutoSize = true
            };

            Controls.Add(welcome);

            // Center the text
            welcome.Location = new Point(
                (ClientSize.Width - welcome.Width) / 2,
                (ClientSize.Height - welcome.Height) / 2
            );

            // Keep text centered when window is resized
            Resize += (s, e) =>
            {
                welcome.Location = new Point(
                    (ClientSize.Width - welcome.Width) / 2,
                    (ClientSize.Height - welcome.Height) / 2
                );
            };
        }
    }
}