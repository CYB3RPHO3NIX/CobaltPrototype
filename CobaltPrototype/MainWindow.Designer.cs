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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            statusStrip1 = new StatusStrip();
            tsLabelConnectivity = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            connectToolStripMenuItem = new ToolStripMenuItem();
            tsButtonDatabase = new ToolStripDropDownButton();
            tsButtonSchema = new ToolStripDropDownButton();
            tsButtonTable = new ToolStripDropDownButton();
            flowLayoutPanel = new FlowLayoutPanel();
            btnAddNewFilter = new Button();
            tsTableStatistics = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
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
            // tsTableStatistics
            // 
            tsTableStatistics.Name = "tsTableStatistics";
            tsTableStatistics.Size = new Size(83, 17);
            tsTableStatistics.Text = "Table Statistics";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 521);
            Controls.Add(flowLayoutPanel);
            Controls.Add(statusStrip1);
            Name = "MainWindow";
            Text = "Cobalt Prototype";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
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
    }
}
