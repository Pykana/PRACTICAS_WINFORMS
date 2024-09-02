using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Prestamos.Context;
using System.IO;

namespace Sistema_de_Prestamos.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        private DB_Entities data = new DB_Entities();
        private int IdCapturado;
        private Login loginForm;

        public MenuPrincipal(int idUsuario)
        {
            InitializeComponent();
            IdCapturado = idUsuario;
          //  loginForm = Partelogin;

            cargarNombreEImagen();
            ImagenPerfilUsuario.Paint += ImagenPerfilUsuario_Paint;
        }
        private void cargarNombreEImagen( ) {

            Usuario usuarioEncontrado = data.Usuario.FirstOrDefault(x => x.idUsuario == IdCapturado);
            lblNombreUsuario.Text = usuarioEncontrado.NombreUsuario +" "+usuarioEncontrado.ApellidosUsuario;


            ////NOMBRE USUARIO
            //nombreCaptado = UsuarioLogeado.ParteDatos.NombreUsuario;
            ////RUTA IMAGEN
            //NombreImagen = UsuarioLogeado.ParteImagen.NombreImagen;
            //imagenCaptada = UsuarioLogeado.ParteImagen.DatosImagen;
            ////VALIDAR IAMGEN Y NOMBRE
            //if (string.IsNullOrEmpty(nombreCaptado)) {
            //    lblNombreUsuario.Text = nombreCaptado;
            //}
            //if (imagenCaptada != null)
            //{
            //    //CREAR IMAGEN 
            //    File.WriteAllBytes("~/Temp/" + NombreImagen, imagenCaptada);
            //    Bitmap imagen = new Bitmap("~/Temp/" + NombreImagen);
            //    ImagenPerfilUsuario.Image = imagen;
            //}
        }

        private void ImagenPerfilUsuario_Paint(object sender, PaintEventArgs e)
        {
            // Definir el tamaño y la forma del borde circular
            int borderThickness = 5;
            int diameter = Math.Min(ImagenPerfilUsuario.Width, ImagenPerfilUsuario.Height) - borderThickness;
            // Calcular la posición centrada para la imagen dentro del PictureBox
            int x = (ImagenPerfilUsuario.Width - diameter) / 2;
            int y = (ImagenPerfilUsuario.Height - diameter) / 2;
            // Crear un gráfico que permita el recorte circular
            using (GraphicsPath path = new GraphicsPath())
            {
                // Crear un círculo para recortar la imagen
                path.AddEllipse(x, y, diameter, diameter);
                ImagenPerfilUsuario.Region = new Region(path);

                // Dibujar la imagen dentro del círculo centrado
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                if (ImagenPerfilUsuario.Image != null) {
                    e.Graphics.DrawImage(ImagenPerfilUsuario.Image, new Rectangle(x, y, diameter, diameter));
                }
               
                // Dibujar el borde circular de color negro
                using (Pen pen = new Pen(Color.White, borderThickness))
                {
                    e.Graphics.DrawEllipse(pen, x, y, diameter, diameter);
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible)
            {
                Application.Exit();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes ClienteControl = new Clientes();
            ClienteControl.Dock = DockStyle.Fill;
            PanelSelect.Controls.Clear();
            PanelSelect.Controls.Add(ClienteControl);
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora CalculadoraControl = new Calculadora();
            CalculadoraControl.Dock = DockStyle.Fill;
            PanelSelect.Controls.Clear();
            PanelSelect.Controls.Add(CalculadoraControl);
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            EstadoPrestamo EstadoPrestamoControl = new EstadoPrestamo();
            EstadoPrestamoControl.Dock = DockStyle.Fill;
            PanelSelect.Controls.Clear();
            PanelSelect.Controls.Add(EstadoPrestamoControl);
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            Resumen ResumenControl = new Resumen();
            ResumenControl.Dock = DockStyle.Fill;
            PanelSelect.Controls.Clear();
            PanelSelect.Controls.Add(ResumenControl);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion ConfiguracionControl = new Configuracion();
            ConfiguracionControl.Dock = DockStyle.Fill;
           // ConfiguracionControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;


            PanelSelect.Controls.Clear();
            PanelSelect.Controls.Add(ConfiguracionControl);
        }

    }
}
