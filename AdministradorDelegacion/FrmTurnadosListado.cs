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
    public partial class FrmTurnadosListado : Form
    {
        public FrmTurnadosListado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTurnados frm = new FrmTurnados();
            frm.ShowDialog();
        }
    }
}
