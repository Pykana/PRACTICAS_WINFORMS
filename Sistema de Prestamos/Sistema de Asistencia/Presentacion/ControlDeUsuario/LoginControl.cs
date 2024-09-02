using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Prestamos.Logica;
using Sistema_de_Prestamos.Context;

namespace Sistema_de_Prestamos.Presentacion
{
    public partial class LoginControl : UserControl
    {
        private DB_Entities data = new DB_Entities();
        public event EventHandler SwitchToRegister;

        public LoginControl()
        {
            InitializeComponent();
        }

        public void LimpiarData() {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese Correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Encriptar la contraseña ingresada
            Encriptamiento_Desencriptamiento Seguridad = new Encriptamiento_Desencriptamiento(txtContrasena.Text);
            byte[] contrasenaEncriptada = Seguridad.EncriptarClave(txtContrasena.Text);
            // Buscar el usuario basado en el correo
            Usuario usuarioEncontrado = data.Usuario.FirstOrDefault(x => x.Correo == txtUsuario.Text);
            // Verificar si el usuario fue encontrado y la contraseña coincide
            if (usuarioEncontrado != null && usuarioEncontrado.Contrasena.SequenceEqual(contrasenaEncriptada))
            {
                MenuPrincipal Main = new MenuPrincipal(usuarioEncontrado.idUsuario);
                LimpiarData();
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no registrado o contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblLinkRegistro_LinkClicked(object sender, EventArgs e)
        {
            SwitchToRegister?.Invoke(this, EventArgs.Empty);
        }
     
        private void LoginControl_Load(object sender, EventArgs e)
        {
            LimpiarData();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
