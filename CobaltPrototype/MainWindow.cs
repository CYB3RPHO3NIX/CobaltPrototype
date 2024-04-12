using CobaltPrototype.Models;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace CobaltPrototype
{
    public partial class MainWindow : Form
    {
        private DatabaseManager _databaseManager;
        private DataManager _dataManager;

        private string _ServerName;
        private string _DatabaseName;
        public MainWindow()
        {
            InitializeComponent();
            cbPageSize.SelectedIndex = 3;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ServerNamePopup popup = new ServerNamePopup())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string enteredText = popup._ServerName;
                    this._ServerName = enteredText;
                    _databaseManager = new DatabaseManager(enteredText);
                    CrossThreadSafeUpdate.UpdateToolStripStatusLabel(tsLabelConnectivity, $"Server Connected: {enteredText}");
                    LoadDatabaseDropdown();
                }
            }
        }
        private void LoadDatabaseDropdown()
        {
            tsButtonDatabase.DropDownItems.Clear();
            _databaseManager.GetAllDatabases();
            foreach (var item in _databaseManager._databases)
            {
                if (item.IsSelected)
                {
                    ToolStripMenuItem option = new ToolStripMenuItem(item.Name);
                    option.ForeColor = Color.Green;
                    option.Font = new System.Drawing.Font(option.Font, System.Drawing.FontStyle.Bold);
                    tsButtonDatabase.DropDownItems.Add(option);
                }
                else
                {
                    ToolStripMenuItem option = new ToolStripMenuItem(item.Name);
                    tsButtonDatabase.DropDownItems.Add(option);
                }
            }
        }
        private void LoadSchemaDropdown()
        {
            tsButtonSchema.DropDownItems.Clear();
            _databaseManager.GetAllSchemas();
            foreach (var item in _databaseManager._schemas)
            {
                if (item.IsSelected)
                {
                    ToolStripMenuItem option = new ToolStripMenuItem(item.Name);
                    option.ForeColor = Color.Green;
                    option.Font = new System.Drawing.Font(option.Font, System.Drawing.FontStyle.Bold);
                    tsButtonSchema.DropDownItems.Add(option);
                }
                else
                {
                    ToolStripMenuItem option = new ToolStripMenuItem(item.Name);
                    tsButtonSchema.DropDownItems.Add(option);
                }
            }
        }
        private void LoadTableDropdown()
        {
            tsButtonTable.DropDownItems.Clear();
            _databaseManager.GetAllTablesOrViews();
            foreach (var item in _databaseManager._tables)
            {
                if (item.IsSelected)
                {
                    ToolStripMenuItem option = new ToolStripMenuItem(item.Name);
                    option.ForeColor = Color.Green;
                    option.Font = new System.Drawing.Font(option.Font, System.Drawing.FontStyle.Bold);
                    tsButtonTable.DropDownItems.Add(option);
                }
                else
                {
                    ToolStripMenuItem option = new ToolStripMenuItem(item.Name);
                    tsButtonTable.DropDownItems.Add(option);
                }
            }
        }

        private void tsButtonDatabase_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tsButtonDatabase.Text = e.ClickedItem?.Text;
            _databaseManager.SelectDatabase(e.ClickedItem?.Text);
            _DatabaseName = e.ClickedItem?.Text;
            _dataManager = new DataManager(_ServerName, _DatabaseName);
            //If the user has selected then get all schemas within that database.

            LoadSchemaDropdown();
        }
        private void tsButtonSchema_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tsButtonSchema.Text = e.ClickedItem?.Text;
            _databaseManager.SelectSchema(e.ClickedItem?.Text);
            //If the user has selected then get all table within that Schema.

            LoadTableDropdown();
        }
        private void tsButtonTable_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _databaseManager.SelectTable(e.ClickedItem?.Text);
            tsButtonTable.Text = e.ClickedItem?.Text;
        }

        private void ShowTableData()
        {
            ClearDataGrid();
            string schema = _databaseManager.GetSelectedSchema();
            string table = _databaseManager.GetSelectedTable();
            var data = _dataManager.GetData(schema, table, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(cbPageSize.SelectedItem));
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = data;
        }
        private void ClearDataGrid()
        {
            dataGridView.DataSource = null;
        }
        private void UpdateTableStatistics(int pageNo, int totalPage, int pageSize)
        {
            CrossThreadSafeUpdate.UpdateToolStripStatusLabel(tsTableStatistics, $"Showing Page {pageNo} of {totalPage} (Page Size: {pageSize})");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowTableData();
        }
    }
}
