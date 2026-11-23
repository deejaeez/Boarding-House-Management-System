using System.Drawing;
using System.Windows.Forms;

namespace BoardingHouseGUI
{
    class DashboardForm : Form
    {
        public DashboardForm()
        {
            // ---------- Window ----------
            Text = "Boarding House Management System";
            WindowState = FormWindowState.Maximized;
            BackColor = ColorTranslator.FromHtml("#DAD7CD");
            Font = new Font("Georgia", 10);

            // ---------- Header (dark green strip with title and date) ----------
            Panel header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 75;
            header.BackColor = ColorTranslator.FromHtml("#344E41");

            Label title = new Label();
            title.Text = "MGQ Boarding House";
            title.Dock = DockStyle.Left;
            title.Width = 400;
            title.Padding = new Padding(30, 0, 0, 0);
            title.Font = new Font("Georgia", 18, FontStyle.Italic);
            title.ForeColor = Color.White;
            title.TextAlign = ContentAlignment.MiddleLeft;

            header.Controls.Add(title);

            // ---------- Buttons (green = actions, light = logout) ----------
            FlowLayoutPanel buttonBar = new FlowLayoutPanel();
            buttonBar.Dock = DockStyle.Top;
            buttonBar.Height = 48;

            Button btnAddRoom = new Button();
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Size = new Size(130, 40);
            btnAddRoom.Margin = new Padding(0, 0, 10, 0);
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.BackColor = ColorTranslator.FromHtml("#3A5A40");
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Cursor = Cursors.Hand;

            Button btnAddTenant = new Button();
            btnAddTenant.Text = "Add Tenant";
            btnAddTenant.Size = new Size(130, 40);
            btnAddTenant.Margin = new Padding(0, 0, 10, 0);
            btnAddTenant.FlatStyle = FlatStyle.Flat;
            btnAddTenant.FlatAppearance.BorderSize = 0;
            btnAddTenant.BackColor = ColorTranslator.FromHtml("#3A5A40");
            btnAddTenant.ForeColor = Color.White;
            btnAddTenant.Cursor = Cursors.Hand;

            Button btnPayment = new Button();
            btnPayment.Text = "Record Payment";
            btnPayment.Size = new Size(150, 40);
            btnPayment.Margin = new Padding(0, 0, 10, 0);
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.BackColor = ColorTranslator.FromHtml("#3A5A40");
            btnPayment.ForeColor = Color.White;
            btnPayment.Cursor = Cursors.Hand;

            Button btnMoveOut = new Button();
            btnMoveOut.Text = "Move Out";
            btnMoveOut.Size = new Size(130, 40);
            btnMoveOut.Margin = new Padding(0, 0, 10, 0);
            btnMoveOut.FlatStyle = FlatStyle.Flat;
            btnMoveOut.FlatAppearance.BorderSize = 0;
            btnMoveOut.BackColor = ColorTranslator.FromHtml("#3A5A40");
            btnMoveOut.ForeColor = Color.White;
            btnMoveOut.Cursor = Cursors.Hand;

            Button btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new Size(110, 40);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#A3B18A");
            btnLogout.FlatAppearance.BorderSize = 1;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.BackColor = ColorTranslator.FromHtml("#DAD7CD");
            btnLogout.ForeColor = ColorTranslator.FromHtml("#344E41");
            btnLogout.Cursor = Cursors.Hand;

            buttonBar.Controls.Add(btnAddRoom);
            buttonBar.Controls.Add(btnAddTenant);
            buttonBar.Controls.Add(btnPayment);
            buttonBar.Controls.Add(btnMoveOut);
            buttonBar.Controls.Add(btnLogout);

            // ---------- Search (white box, no border) ----------
            Panel searchPanel = new Panel();
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Height = 46;
            searchPanel.BackColor = Color.White;
            searchPanel.Padding = new Padding(16, 13, 16, 8);

            TextBox searchBox = new TextBox();
            searchBox.Dock = DockStyle.Fill;
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.ForeColor = ColorTranslator.FromHtml("#344E41");
            searchBox.PlaceholderText = "Search by tenant name or room number";
            searchPanel.Controls.Add(searchBox);

            // ---------- Empty spacers (just gaps between sections) ----------
            Panel gapAboveSearch = new Panel();
            gapAboveSearch.Dock = DockStyle.Top;
            gapAboveSearch.Height = 16;

            Panel gapBelowSearch = new Panel();
            gapBelowSearch.Dock = DockStyle.Top;
            gapBelowSearch.Height = 16;

            // ---------- Table 1: Room Occupancy ----------
            DataGridView roomsGrid = new DataGridView();
            roomsGrid.Dock = DockStyle.Fill;
            roomsGrid.ReadOnly = true;
            roomsGrid.AllowUserToAddRows = false;
            roomsGrid.RowHeadersVisible = false;
            roomsGrid.BackgroundColor = Color.White;
            roomsGrid.BorderStyle = BorderStyle.None;
            roomsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            roomsGrid.GridColor = ColorTranslator.FromHtml("#DAD7CD");
            roomsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomsGrid.RowTemplate.Height = 36;
            roomsGrid.EnableHeadersVisualStyles = false;
            roomsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            roomsGrid.ColumnHeadersHeight = 40;
            roomsGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3A5A40");
            roomsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            roomsGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3A5A40");
            roomsGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            roomsGrid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#344E41");
            roomsGrid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#A3B18A");
            roomsGrid.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#344E41");
            roomsGrid.Columns.Add("room", "Room");
            roomsGrid.Columns.Add("rate", "Monthly Rate");
            roomsGrid.Columns.Add("status", "Status");
            roomsGrid.Columns.Add("tenant", "Tenant");

            Label roomsTitle = new Label();
            roomsTitle.Text = "Room Occupancy";
            roomsTitle.Dock = DockStyle.Top;
            roomsTitle.Height = 40;
            roomsTitle.Font = new Font("Segoe UI Semibold", 12);
            roomsTitle.ForeColor = ColorTranslator.FromHtml("#344E41");
            roomsTitle.TextAlign = ContentAlignment.MiddleLeft;

            Panel roomsCard = new Panel();
            roomsCard.Dock = DockStyle.Fill;
            roomsCard.BackColor = Color.White;
            roomsCard.Padding = new Padding(20, 14, 20, 14);
            roomsCard.Margin = new Padding(0, 0, 8, 0);
            roomsCard.Controls.Add(roomsGrid);    // Fill first
            roomsCard.Controls.Add(roomsTitle);   // then Top

            // ---------- Table 2: Unpaid Balances ----------
            DataGridView unpaidGrid = new DataGridView();
            unpaidGrid.Dock = DockStyle.Fill;
            unpaidGrid.ReadOnly = true;
            unpaidGrid.AllowUserToAddRows = false;
            unpaidGrid.RowHeadersVisible = false;
            unpaidGrid.BackgroundColor = Color.White;
            unpaidGrid.BorderStyle = BorderStyle.None;
            unpaidGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            unpaidGrid.GridColor = ColorTranslator.FromHtml("#DAD7CD");
            unpaidGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            unpaidGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            unpaidGrid.RowTemplate.Height = 36;
            unpaidGrid.EnableHeadersVisualStyles = false;
            unpaidGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            unpaidGrid.ColumnHeadersHeight = 40;
            unpaidGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3A5A40");
            unpaidGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            unpaidGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3A5A40");
            unpaidGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            unpaidGrid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#344E41");
            unpaidGrid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#A3B18A");
            unpaidGrid.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#344E41");
            unpaidGrid.Columns.Add("tenant", "Tenant");
            unpaidGrid.Columns.Add("room", "Room");
            unpaidGrid.Columns.Add("balance", "Balance");
            unpaidGrid.Columns.Add("status", "Status");

            Label unpaidTitle = new Label();
            unpaidTitle.Text = "Tenants with Unpaid Balances";
            unpaidTitle.Dock = DockStyle.Top;
            unpaidTitle.Height = 40;
            unpaidTitle.Font = new Font("Segoe UI Semibold", 12);
            unpaidTitle.ForeColor = ColorTranslator.FromHtml("#344E41");
            unpaidTitle.TextAlign = ContentAlignment.MiddleLeft;

            Panel unpaidCard = new Panel();
            unpaidCard.Dock = DockStyle.Fill;
            unpaidCard.BackColor = Color.White;
            unpaidCard.Padding = new Padding(20, 14, 20, 14);
            unpaidCard.Margin = new Padding(8, 0, 0, 0);
            unpaidCard.Controls.Add(unpaidGrid);    // Fill first
            unpaidCard.Controls.Add(unpaidTitle);   // then Top

            // ---------- Two equal columns that hold the cards ----------
            TableLayoutPanel tables = new TableLayoutPanel();
            tables.Dock = DockStyle.Fill;
            tables.ColumnCount = 2;
            tables.RowCount = 1;
            tables.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tables.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tables.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tables.Controls.Add(roomsCard, 0, 0);
            tables.Controls.Add(unpaidCard, 1, 0);

            // ---------- Main area (padding gives the page margins) ----------
            Panel content = new Panel();
            content.Dock = DockStyle.Fill;
            content.Padding = new Padding(30, 24, 30, 30);
            content.Controls.Add(tables);          // Fill first
            content.Controls.Add(gapBelowSearch);  // then Top, from bottom to top
            content.Controls.Add(searchPanel);
            content.Controls.Add(gapAboveSearch);
            content.Controls.Add(buttonBar);

            // ---------- Add to window: Fill first, then Top ----------
            Controls.Add(content);
            Controls.Add(header);
        }
    }
}