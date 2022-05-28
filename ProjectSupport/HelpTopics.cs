using System;
using System.Windows.Forms;
using System.Drawing;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
namespace ProjectSupport
{


    public partial class HelpTopics : UserControl
    {
        public EventHandler backBtClickHelp;

       


        public HelpTopics()
        {
            InitializeComponent();

        }

        private void naviPanel_paint(object sender, PaintEventArgs e)
        {
      
        }

        private void faqUserControl_Load(object sender, EventArgs e)
        {
           
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            EventHandler click = backBtClickHelp;
            click?.Invoke(this, e);
        }

       

        private void answearRT_TextChanged(object sender, EventArgs e)
        {
            answearRT.ReadOnly = true;
        }
    }
}
