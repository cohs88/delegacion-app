﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdministradorDelegacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
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
            FrmAltaUsuarios f = new FrmAltaUsuarios();
            f.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAltaUsuarios f = new FrmAltaUsuarios();
            f.ShowDialog();
        }
    }
}
