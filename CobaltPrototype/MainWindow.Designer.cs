namespace CobaltPrototype
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            statusStrip1 = new StatusStrip();
            tsLabelConnectivity = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            connectToolStripMenuItem = new ToolStripMenuItem();
            tsButtonDatabase = new ToolStripDropDownButton();
            tsButtonSchema = new ToolStripDropDownButton();
            tsButtonTable = new ToolStripDropDownButton();
            tsTableStatistics = new ToolStripStatusLabel();
            flowLayoutPanel = new FlowLayoutPanel();
            btnAddNewFilter = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnFirstPage = new Button();
            btnPreviousPage = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cbPageSize = new ComboBox();
            btnNextPage = new Button();
            btnLastPage = new Button();
            bindingSource1 = new BindingSource(components);
            dataGridView = new DataGridView();
            btnRefresh = new Button();
            statusStrip1.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsLabelConnectivity, toolStripSplitButton1, tsButtonDatabase, tsButtonSchema, tsButtonTable, tsTableStatistics });
            statusStrip1.Location = new Point(0, 499);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(894, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsLabelConnectivity
            // 
            tsLabelConnectivity.Name = "tsLabelConnectivity";
            tsLabelConnectivity.Size = new Size(142, 17);
            tsLabelConnectivity.Text = "Database: Not Connected";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(79, 20);
            toolStripSplitButton1.Text = "SQL Server";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(119, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // tsButtonDatabase
            // 
            tsButtonDatabase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsButtonDatabase.Image = (Image)resources.GetObject("tsButtonDatabase.Image");
            tsButtonDatabase.ImageTransparentColor = Color.Magenta;
            tsButtonDatabase.Name = "tsButtonDatabase";
            tsButtonDatabase.Size = new Size(68, 20);
            tsButtonDatabase.Text = "Database";
            tsButtonDatabase.DropDownItemClicked += tsButtonDatabase_DropDownItemClicked;
            // 
            // tsButtonSchema
            // 
            tsButtonSchema.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsButtonSchema.Image = (Image)resources.GetObject("tsButtonSchema.Image");
            tsButtonSchema.ImageTransparentColor = Color.Magenta;
            tsButtonSchema.Name = "tsButtonSchema";
            tsButtonSchema.Size = new Size(62, 20);
            tsButtonSchema.Text = "Schema";
            tsButtonSchema.DropDownItemClicked += tsButtonSchema_DropDownItemClicked;
            // 
            // tsButtonTable
            // 
            tsButtonTable.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsButtonTable.Image = (Image)resources.GetObject("tsButtonTable.Image");
            tsButtonTable.ImageTransparentColor = Color.Magenta;
            tsButtonTable.Name = "tsButtonTable";
            tsButtonTable.Size = new Size(47, 20);
            tsButtonTable.Text = "Table";
            tsButtonTable.DropDownItemClicked += tsButtonTable_DropDownItemClicked;
            // 
            // tsTableStatistics
            // 
            tsTableStatistics.Name = "tsTableStatistics";
            tsTableStatistics.Size = new Size(83, 17);
            tsTableStatistics.Text = "Table Statistics";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.Controls.Add(btnAddNewFilter);
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(894, 29);
            flowLayoutPanel.TabIndex = 2;
            // 
            // btnAddNewFilter
            // 
            btnAddNewFilter.Location = new Point(3, 3);
            btnAddNewFilter.Name = "btnAddNewFilter";
            btnAddNewFilter.Size = new Size(93, 23);
            btnAddNewFilter.TabIndex = 0;
            btnAddNewFilter.Text = "Add new Filter";
            btnAddNewFilter.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(btnFirstPage);
            flowLayoutPanel1.Controls.Add(btnPreviousPage);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numericUpDown1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(cbPageSize);
            flowLayoutPanel1.Controls.Add(btnNextPage);
            flowLayoutPanel1.Controls.Add(btnLastPage);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 470);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(894, 29);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Location = new Point(3, 3);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(75, 23);
            btnFirstPage.TabIndex = 3;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(84, 3);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(75, 23);
            btnPreviousPage.TabIndex = 0;
            btnPreviousPage.Text = "<-";
            btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(165, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 29);
            label3.TabIndex = 4;
            label3.Text = "Page";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(204, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(264, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 29);
            label2.TabIndex = 6;
            label2.Text = "Of 100";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(392, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 29);
            label1.TabIndex = 7;
            label1.Text = "Show";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbPageSize
            // 
            cbPageSize.FormattingEnabled = true;
            cbPageSize.Items.AddRange(new object[] { "10", "20", "50", "100", "500", "1000" });
            cbPageSize.Location = new Point(434, 3);
            cbPageSize.Name = "cbPageSize";
            cbPageSize.Size = new Size(67, 23);
            cbPageSize.TabIndex = 8;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(507, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(75, 23);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "->";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            btnLastPage.Location = new Point(588, 3);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(75, 23);
            btnLastPage.TabIndex = 2;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 29);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(894, 441);
            dataGridView.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(311, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 521);
            Controls.Add(dataGridView);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(statusStrip1);
            Name = "MainWindow";
            Text = "Cobalt Prototype";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsLabelConnectivity;
        private ToolStripDropDownButton tsButtonDatabase;
        private ToolStripDropDownButton tsButtonSchema;
        private ToolStripDropDownButton tsButtonTable;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnAddNewFilter;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripStatusLabel tsTableStatistics;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Button btnLastPage;
        private Button btnFirstPage;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private ComboBox cbPageSize;
        private BindingSource bindingSource1;
        private DataGridView dataGridView;
        private Button btnRefresh;
    }
}
