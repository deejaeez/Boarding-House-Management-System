
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoardingHouseGUI
{
    class DashboardForm : Form
    {
        public DashboardForm()
        {
            Text = "Boarding House Management System";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(218, 215, 205);
            Font = new Font("Georgia", 12);

            // ---------- Header ----------
            Panel header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 130;
            header.BackColor = Color.FromArgb(52, 78, 65);

            Label title = new Label();
            title.Text = "MGQ Boarding House";
            title.Dock = DockStyle.Left;
            title.Width = 450;
            title.Padding = new Padding(30, 0, 0, 0);
            title.Font = new Font("Georgia", 23, FontStyle.Italic);
            title.ForeColor = Color.White;
            title.TextAlign = ContentAlignment.MiddleLeft;

            header.Controls.Add(title);

            // ---------- Sidebar ----------
            Panel sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 250;
            sidebar.BackColor = Color.FromArgb(38, 61, 51);

            // ---------- Sidebar Button Layout ----------
            FlowLayoutPanel buttonBar = new FlowLayoutPanel();
            buttonBar.Dock = DockStyle.Fill;
            buttonBar.FlowDirection = FlowDirection.TopDown;
            buttonBar.WrapContents = false;
            buttonBar.Padding = new Padding(10, 15, 10, 0);
            buttonBar.AutoScroll = true;
            buttonBar.BackColor = Color.FromArgb(38, 61, 51);

            // ---------- Main Menu Title ----------
            Label mainMenuTitle = new Label();
            mainMenuTitle.Text = "MAIN MENU";
            mainMenuTitle.Size = new Size(220, 40);
            mainMenuTitle.Margin = new Padding(0, 0, 0, 5);
            mainMenuTitle.Font = new Font("Segoe UI Semibold", 10);
            mainMenuTitle.ForeColor = Color.FromArgb(190, 205, 193);
            mainMenuTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ---------- Dashboard Button ----------
            Button btnDashboard = new Button();
            btnDashboard.Text = "Dashboard";
            btnDashboard.Size = new Size(220, 65);
            btnDashboard.Margin = new Padding(0, 0, 0, 10);
            btnDashboard.Font = new Font("Georgia", 14);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.BackColor = Color.FromArgb(82, 109, 91);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Cursor = Cursors.Hand;

            // ---------- Add Room Button ----------
            Button btnAddRoom = new Button();
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Size = new Size(220, 65);
            btnAddRoom.Margin = new Padding(0, 0, 0, 10);
            btnAddRoom.Font = new Font("Georgia", 14);
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.BackColor = Color.FromArgb(58, 90, 64);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Cursor = Cursors.Hand;

            // ---------- Add Tenant Button ----------
            Button btnAddTenant = new Button();
            btnAddTenant.Text = "Add Tenant";
            btnAddTenant.Size = new Size(220, 65);
            btnAddTenant.Margin = new Padding(0, 0, 0, 10);
            btnAddTenant.Font = new Font("Georgia", 14);
            btnAddTenant.FlatStyle = FlatStyle.Flat;
            btnAddTenant.FlatAppearance.BorderSize = 0;
            btnAddTenant.BackColor = Color.FromArgb(58, 90, 64);
            btnAddTenant.ForeColor = Color.White;
            btnAddTenant.Cursor = Cursors.Hand;

            // ---------- Record Payment Button ----------
            Button btnPayment = new Button();
            btnPayment.Text = "Record Payment";
            btnPayment.Size = new Size(220, 65);
            btnPayment.Margin = new Padding(0, 0, 0, 10);
            btnPayment.Font = new Font("Georgia", 14);
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.BackColor = Color.FromArgb(58, 90, 64);
            btnPayment.ForeColor = Color.White;
            btnPayment.Cursor = Cursors.Hand;

            // ---------- Move Out Button ----------
            Button btnMoveOut = new Button();
            btnMoveOut.Text = "Move Out";
            btnMoveOut.Size = new Size(220, 65);
            btnMoveOut.Margin = new Padding(0, 0, 0, 10);
            btnMoveOut.Font = new Font("Georgia", 14);
            btnMoveOut.FlatStyle = FlatStyle.Flat;
            btnMoveOut.FlatAppearance.BorderSize = 0;
            btnMoveOut.BackColor = Color.FromArgb(58, 90, 64);
            btnMoveOut.ForeColor = Color.White;
            btnMoveOut.Cursor = Cursors.Hand;

            // ---------- Management Title ----------
            Label managementTitle = new Label();
            managementTitle.Text = "MANAGEMENT";
            managementTitle.Size = new Size(220, 40);
            managementTitle.Margin = new Padding(0, 15, 0, 5);
            managementTitle.Font = new Font("Segoe UI Semibold", 10);
            managementTitle.ForeColor = Color.FromArgb(190, 205, 193);
            managementTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ---------- Room Occupancy Button ----------
            Button btnRoomOccupancy = new Button();
            btnRoomOccupancy.Text = "Room Occupancy";
            btnRoomOccupancy.Size = new Size(220, 65);
            btnRoomOccupancy.Margin = new Padding(0, 0, 0, 10);
            btnRoomOccupancy.Font = new Font("Georgia", 14);
            btnRoomOccupancy.FlatStyle = FlatStyle.Flat;
            btnRoomOccupancy.FlatAppearance.BorderSize = 0;
            btnRoomOccupancy.BackColor = Color.FromArgb(58, 90, 64);
            btnRoomOccupancy.ForeColor = Color.White;
            btnRoomOccupancy.Cursor = Cursors.Hand;

            // ---------- Unpaid Balances Button ----------
            Button btnUnpaidBalances = new Button();
            btnUnpaidBalances.Text = "Unpaid Balances";
            btnUnpaidBalances.Size = new Size(220, 65);
            btnUnpaidBalances.Margin = new Padding(0, 0, 0, 10);
            btnUnpaidBalances.Font = new Font("Georgia", 14);
            btnUnpaidBalances.FlatStyle = FlatStyle.Flat;
            btnUnpaidBalances.FlatAppearance.BorderSize = 0;
            btnUnpaidBalances.BackColor = Color.FromArgb(58, 90, 64);
            btnUnpaidBalances.ForeColor = Color.White;
            btnUnpaidBalances.Cursor = Cursors.Hand;

            // ---------- Add Buttons to Sidebar ----------
            buttonBar.Controls.Add(mainMenuTitle);
            buttonBar.Controls.Add(btnDashboard);
            buttonBar.Controls.Add(btnAddRoom);
            buttonBar.Controls.Add(btnAddTenant);
            buttonBar.Controls.Add(btnPayment);
            buttonBar.Controls.Add(btnMoveOut);

            buttonBar.Controls.Add(managementTitle);
            buttonBar.Controls.Add(btnRoomOccupancy);
            buttonBar.Controls.Add(btnUnpaidBalances);

            // ---------- Logout Button ----------
            Panel logoutPanel = new Panel();
            logoutPanel.Dock = DockStyle.Bottom;
            logoutPanel.Height = 85;
            logoutPanel.Padding = new Padding(15, 10, 15, 15);
            logoutPanel.BackColor = Color.FromArgb(38, 61, 51);

            Button btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.Font = new Font("Georgia", 14);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderColor =
                Color.FromArgb(163, 177, 138);
            btnLogout.FlatAppearance.BorderSize = 1;
            btnLogout.BackColor = Color.FromArgb(218, 215, 205);
            btnLogout.ForeColor = Color.FromArgb(52, 78, 65);
            btnLogout.Cursor = Cursors.Hand;

            logoutPanel.Controls.Add(btnLogout);

            sidebar.Controls.Add(buttonBar);
            sidebar.Controls.Add(logoutPanel);

            // ---------- Main Content Panel ----------
            Panel contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.FromArgb(218, 215, 205);
            contentPanel.Padding = new Padding(30);

            // Dashboard content will be added later.

            // ---------- Main Layout ----------
            Panel mainLayout = new Panel();
            mainLayout.Dock = DockStyle.Fill;

            mainLayout.Controls.Add(contentPanel);
            mainLayout.Controls.Add(sidebar);

            // ---------- Add to Form ----------
            Controls.Add(mainLayout);
            Controls.Add(header);
        }
    }
}
