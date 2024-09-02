using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Prestamos.Context;
using Sistema_de_Prestamos.Logica;

namespace Sistema_de_Prestamos.Presentacion
{
    public partial class Registro : Form
    {
        private Login loginForm;
        private DB_Entities data = new DB_Entities();

        public Registro(Login Partelogin)
        {
            InitializeComponent();
            loginForm = Partelogin;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible)
            {
                Application.Exit();
            }
        }

        private string validarCampos() {
            var campos = new Dictionary<KryptonTextBox, string>  // (KEY  , VALUE) 
                {
                    { txtNombre, "Ingrese Nombre" },
                    { txtApellidos, "Ingrese Apellidos" },
                    { txtTelefono, "Ingrese Telefono" },
                    { txtCorreo, "Ingrese Email" },
                    { txtDNI, "Ingrese DNI" },
                    { txtContraseña, "Ingrese Contraseña" },
                    { txtConfimarContraseña, "Ingrese Contraseña" }
                };

            foreach (var campo in campos)
            {
                if (string.IsNullOrEmpty(campo.Key.Text)) // TXT
                {
                    return campo.Value;  // RESPUESTA
                }
            }
            return ""; // EN CASO DE QUE TODOS LOS CAMPOS NO ESTEN VACIOS
        }

        private string validarLongitud()
        {
            var campos = new Dictionary<KryptonTextBox, string>  // (KEY  , VALUE) 
                {
                    { txtTelefono, "El Telefono debe ser de 9 digitos" },
                    { txtDNI, "El DNI debe ser de 8 digitos" },
                };

            foreach (var campo in campos)
            {
                if ((campo.Key == txtTelefono && campo.Key.Text.Length != 9) ||
                    (campo.Key == txtDNI && campo.Key.Text.Length != 8))
                {
                    return campo.Value;
                }
            }
            return ""; 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string respuestaValidacion = validarCampos();

            if (respuestaValidacion == "")
            {
                string respuestaLongitud = validarLongitud();

                if (respuestaLongitud == "")
                {
                    if (txtContraseña.Text == txtConfimarContraseña.Text)
                    {
                        try
                        {
                            int telefono = int.Parse(txtTelefono.Text);
                            int dni = int.Parse(txtDNI.Text);

                            if (data.Usuario.Any(u => u.Telefono == telefono))
                            {
                                MessageBox.Show("El teléfono ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (data.Usuario.Any(u => u.Correo == txtCorreo.Text))
                            {
                                MessageBox.Show("El correo ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (data.Usuario.Any(u => u.DNI == dni))
                            {
                                MessageBox.Show("El DNI ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            Usuario UsuarioNuevo = new Usuario();
                            Encriptamiento_Desencriptamiento Seguridad = new Encriptamiento_Desencriptamiento(txtContraseña.Text);

                            UsuarioNuevo.NombreUsuario = txtNombre.Text;
                            UsuarioNuevo.ApellidosUsuario = txtApellidos.Text;
                            UsuarioNuevo.Telefono = telefono; // Convert.ToInt32(txtTelefono.Text) ya está hecho
                            UsuarioNuevo.Correo = txtCorreo.Text;  //UNICO
                            UsuarioNuevo.DNI = dni; // Convert.ToInt32(txtDNI.Text) ya está hecho
                            UsuarioNuevo.Contrasena = Seguridad.EncriptarClave(txtContraseña.Text);
                            data.Usuario.Add(UsuarioNuevo);

                            try
                            {
                                data.SaveChanges();
                                MessageBox.Show("Registro Exitoso", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarData();
                                loginForm.Show();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                var innerException = ex.InnerException?.InnerException;
                                MessageBox.Show(innerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no coincide", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Error en la longitud de caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Error en el ingreso de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void LimpiarData() {
            txtApellidos.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtConfimarContraseña.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada
            }
        }
    }
}
