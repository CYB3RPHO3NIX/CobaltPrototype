using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaltPrototype
{
    public partial class ServerNamePopup : Form
    {
        public string _ServerName { get; set; }
        public ServerNamePopup()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.IsConnectionSuccessful(tbServerName.Text))
            {
                this._ServerName = tbServerName.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void tbServerName_Leave(object sender, EventArgs e)
        {
            if (DatabaseHelper.IsConnectionSuccessful(tbServerName.Text))
            {
                labelConnectionStatus.Text = "Connection Successful";
            }
            else
            {
                labelConnectionStatus.Text = "Server not found";
            }
        }
    }
}
