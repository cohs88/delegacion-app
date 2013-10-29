using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AdministradorDelegacion.BLL;

namespace AdministradorDelegacion
{
    public partial class FrmUsuarios : Form
    {
        Usuario usuarioObj;
        public FrmUsuarios()
        {
            InitializeComponent();
            usuarioObj = new Usuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaUsuarios f = new FrmAltaUsuarios(this);
            f.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAltaUsuarios f = new FrmAltaUsuarios(this);
            f.ShowDialog();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        public void FillDgv()
        {
            dgvDatos.DataSource = usuarioObj.Get();
        }
    }
}
