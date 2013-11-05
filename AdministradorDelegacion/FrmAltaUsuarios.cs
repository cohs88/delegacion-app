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
    public partial class FrmAltaUsuarios : Form
    {
        Rol rolObj;
        Personal personalObj;
        FrmUsuarios frmPadre;
        public bool es_agregar = true;
        public int id;
        public FrmAltaUsuarios(FrmUsuarios frm)
        {
            InitializeComponent();
            frmPadre = frm;
            rolObj = new Rol();
            personalObj = new Personal();

            if (!this.es_agregar)
            {

                txtPassword.Enabled = false;
                txtConfirmarPassword.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuarioObj = new Usuario();
            string usuario = txtUsuario.Text;
            string pwd = txtPassword.Text;
            string confirm_pwd = txtConfirmarPassword.Text;
            int rol_id = 0, empleado_id = 0;

            try
            {
                rol_id = int.Parse(cmbRol.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Rol requerido");
                return;
            }

            try
            {
                empleado_id = int.Parse(cmbEmpleado.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Empleado requerido");
                return;
            }

            try
            {
                usuarioObj.Insert(usuario, pwd, confirm_pwd, empleado_id, rol_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            frmPadre.FillDgv();
            this.Close();
        }

        private void FrmAltaUsuarios_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = rolObj.Get();
            cmbRol.DisplayMember = "nombre";
            cmbRol.ValueMember = "id";

            cmbEmpleado.DataSource = personalObj.GetList();
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.ValueMember = "id";
        }
    }
}
