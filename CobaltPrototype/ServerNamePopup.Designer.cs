namespace CobaltPrototype
{
    partial class ServerNamePopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btnOk = new Button();
            tbServerName = new TextBox();
            labelConnectionStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnOk, 1, 0);
            tableLayoutPanel1.Controls.Add(tbServerName, 0, 0);
            tableLayoutPanel1.Controls.Add(labelConnectionStatus, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(450, 69);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOk.Location = new Point(372, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tbServerName
            // 
            tbServerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbServerName.Location = new Point(3, 3);
            tbServerName.Name = "tbServerName";
            tbServerName.Size = new Size(224, 23);
            tbServerName.TabIndex = 1;
            tbServerName.Text = "THINKPAD";
            tbServerName.Leave += tbServerName_Leave;
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(3, 29);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(224, 40);
            labelConnectionStatus.TabIndex = 2;
            labelConnectionStatus.Text = "Connection Status";
            labelConnectionStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServerNamePopup
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(460, 79);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "ServerNamePopup";
            Padding = new Padding(5);
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "ServerName";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnOk;
        private TextBox tbServerName;
        private Label labelConnectionStatus;
    }
}