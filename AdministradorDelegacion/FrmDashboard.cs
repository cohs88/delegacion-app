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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSiniestrosA frm = new FrmSiniestrosA();
            frm.ShowDialog();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHistorial frm = new FrmHistorial();
            frm.ShowDialog();
        }

        private void agregarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurnados frm = new FrmTurnados();
            frm.ShowDialog();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.ShowDialog();
        }

        private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmSiniestros frm = new FrmSiniestros();
            frm.ShowDialog();
        }

        private void listadoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmTurnadosListado frm = new FrmTurnadosListado();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
