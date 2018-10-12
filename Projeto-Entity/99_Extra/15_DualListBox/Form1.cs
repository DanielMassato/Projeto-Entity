using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DualListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            if (lbx1.SelectedIndex < 0) return;
            while (lbx1.SelectedIndices.Count > 0)
            {
                int NumItem = lbx1.SelectedIndices[0];
                lbx2.Items.Add(lbx1.Items[NumItem]);
                lbx1.Items.RemoveAt(NumItem);
            }
        }

        private void btnVem_Click(object sender, EventArgs e)
        {
            if (lbx2.SelectedIndex < 0) return;
            while (lbx2.SelectedIndices.Count > 0)
            {
                int NumItem = lbx2.SelectedIndices[0];
                lbx1.Items.Add(lbx2.Items[NumItem]);
                lbx2.Items.RemoveAt(NumItem);
            }
        }

        private void btnVaiTudo_Click(object sender, EventArgs e)
        {
            while (lbx1.Items.Count > 0)
            {
                lbx2.Items.Add(lbx1.Items[0]);
                lbx1.Items.RemoveAt(0);
            }
        }

        private void btnVemTudo_Click(object sender, EventArgs e)
        {
            while (lbx2.Items.Count > 0)
            {
                lbx1.Items.Add(lbx2.Items[0]);
                lbx2.Items.RemoveAt(0);
            }
        }



    }
}