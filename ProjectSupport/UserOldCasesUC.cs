﻿using System;
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
    public partial class UserOldCasesUC : UserControl
    {
        public EventHandler replyBtClicked;
        public EventHandler Cos;
        public EventHandler oldCaseLoad;
        public UserOldCasesUC()
        {
            InitializeComponent();
        }

        private void UserOldCasesUC_Load(object sender, EventArgs e)
        {
            EventHandler load = oldCaseLoad;
            load?.Invoke(this, EventArgs.Empty);
        }

        private void casesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void replyBt_Click(object sender, EventArgs e)
        {
            EventHandler buyer = replyBtClicked;
            buyer?.Invoke(this, EventArgs.Empty);
        }

        private void statusLb_Click(object sender, EventArgs e)
        {

        }

        private void titleLb_Click(object sender, EventArgs e)
        {

        }

        private void respondsRt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
