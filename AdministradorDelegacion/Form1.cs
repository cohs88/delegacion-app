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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            
            if (usuario.Equals(""))
            {
                MessageBox.Show("Usuario requerido");
                txtUsuario.Focus();
                return;
            }

            if (password.Equals(""))
            {
                MessageBox.Show("Password requerido");
                txtPassword.Focus();
                return;
            }


            this.Hide();

            FrmDashboard frm = new FrmDashboard();
            frm.ShowDialog();

            this.Close();
            this.Dispose();
            /*
            FrmUsuarios f = new FrmUsuarios();
            f.ShowDialog();
            */
        }
    }
}
