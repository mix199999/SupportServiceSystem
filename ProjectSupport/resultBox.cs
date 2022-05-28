using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSupport
{
    public partial class resultBox : UserControl
    {
        public resultBox()
        {
            InitializeComponent();
        }

        private void resultBoxPanel_Paint(object sender, PaintEventArgs e)
        {
            this.resultBoxPanel.BackColor = Colors.ColorsList[5];
            this.resultBoxPanel.ForeColor = Colors.ColorsList[3];
            this.ResultBoxTitle.BackColor = Colors.ColorsList[5];
            this.ResultBoxTitle.ForeColor = Colors.ColorsList[3];
            this.ResultBoxTx.BackColor = Colors.ColorsList[7];
            this.ResultBoxTx.ForeColor = Colors.ColorsList[3];
        }
    }
}
