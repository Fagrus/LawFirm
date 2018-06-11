using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void pro_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pro_tblBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.protoDataSet1);

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MForm = new Main();
            MForm.Closed += (s, args) => this.Close();
            MForm.Show();
        }
    }
}
