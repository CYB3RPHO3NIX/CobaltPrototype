using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltPrototype
{
    public static class CrossThreadSafeUpdate
    {
        public static void UpdateToolStripStatusLabel(ToolStripStatusLabel label, string newText)
        {
            if (label.GetCurrentParent() != null && label.GetCurrentParent().InvokeRequired)
            {
                label.GetCurrentParent().Invoke(new Action(() => UpdateToolStripStatusLabel(label, newText)));
            }
            else
            {
                label.Text = newText;
            }
        }
    }
}
