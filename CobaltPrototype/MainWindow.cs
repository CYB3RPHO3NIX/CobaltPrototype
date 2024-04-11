using CobaltPrototype.Models;
using static System.Windows.Forms.Design.AxImporter;

namespace CobaltPrototype
{
    public partial class MainWindow : Form
    {
        private DatabaseManager _databaseManager;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ServerNamePopup popup = new ServerNamePopup())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string enteredText = popup._ServerName;
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
            _databaseManager.GetAllTables();
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
            _databaseManager.SelectDatabase(tsButtonDatabase.Text);
            //If the user has selected then get all schemas within that database.
            
            LoadSchemaDropdown();
        }
        private void tsButtonSchema_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tsButtonSchema.Text = e.ClickedItem?.Text;
            _databaseManager.SelectSchema(tsButtonSchema.Text);
            //If the user has selected then get all table within that Schema.
            
            LoadTableDropdown();
        }
        private void tsButtonTable_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _databaseManager.SelectTable(tsButtonTable.Text);
            tsButtonTable.Text = e.ClickedItem?.Text;

            ShowTableData();
        }

        private void ShowTableData()
        {
            
        }
        private void UpdateTableStatistics(int pageNo, int totalPage, int pageSize)
        {
            CrossThreadSafeUpdate.UpdateToolStripStatusLabel(tsTableStatistics, $"Showing Page {pageNo} of {totalPage} (Page Size: {pageSize})");
        }
    }
}
