using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibComponentes
{
    public partial class DBNavigator1 : UserControl
    {
        public DBNavigator1()
        {
            InitializeComponent();
        }

        private BindingSource _bindingSource;

        public BindingSource BindingSource
        {
            get
            {
                return _bindingSource;
            }

            set
            {
                _bindingSource = value;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (_bindingSource != null)
                _bindingSource.MoveFirst();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (_bindingSource != null)
                _bindingSource.MovePrevious();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (_bindingSource != null)
                _bindingSource.MoveNext();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (_bindingSource != null)
                _bindingSource.MoveLast();
        }
    }
}
