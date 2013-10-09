using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdministradorDelegacion
{
    public partial class FrmSiniestrosA : Form
    {
        public FrmSiniestrosA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSiniestrosB frm = new FrmSiniestrosB();
            frm.ShowDialog();
        }
    }
}
