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
    public partial class FrmSiniestros : Form
    {
        public FrmSiniestros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmSiniestrosA frm = new FrmSiniestrosA();
            frm.ShowDialog();
        }
    }
}
