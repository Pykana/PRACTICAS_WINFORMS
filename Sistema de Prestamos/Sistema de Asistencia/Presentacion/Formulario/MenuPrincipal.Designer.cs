namespace Sistema_de_Prestamos.Presentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.Botones = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SeparadorPanel = new System.Windows.Forms.Panel();
            this.btnResumen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInforme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Separador = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCalculadora = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClientes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UsuarioIconoNombre = new System.Windows.Forms.Panel();
            this.NombreUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImagenPerfilUsuario = new System.Windows.Forms.PictureBox();
            this.PanelSelect = new System.Windows.Forms.Panel();
            this.Botones.SuspendLayout();
            this.UsuarioIconoNombre.SuspendLayout();
            this.NombreUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfilUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Botones
            // 
            this.Botones.BackColor = System.Drawing.Color.Black;
            this.Botones.Controls.Add(this.btnConfiguracion);
            this.Botones.Controls.Add(this.SeparadorPanel);
            this.Botones.Controls.Add(this.btnResumen);
            this.Botones.Controls.Add(this.btnInforme);
            this.Botones.Controls.Add(this.Separador);
            this.Botones.Controls.Add(this.btnCerrarSesion);
            this.Botones.Controls.Add(this.btnCalculadora);
            this.Botones.Controls.Add(this.btnClientes);
            this.Botones.Controls.Add(this.UsuarioIconoNombre);
            this.Botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.Botones.Location = new System.Drawing.Point(0, 0);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(239, 561);
            this.Botones.TabIndex = 0;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 381);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnConfiguracion.Size = new System.Drawing.Size(239, 36);
            this.btnConfiguracion.TabIndex = 12;
            this.btnConfiguracion.Values.Image = global::Sistema_de_Prestamos.Properties.Resources.config;
            this.btnConfiguracion.Values.Text = " Configuracion";
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // SeparadorPanel
            // 
            this.SeparadorPanel.BackColor = System.Drawing.Color.Black;
            this.SeparadorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparadorPanel.Location = new System.Drawing.Point(0, 294);
            this.SeparadorPanel.Name = "SeparadorPanel";
            this.SeparadorPanel.Size = new System.Drawing.Size(239, 87);
            this.SeparadorPanel.TabIndex = 11;
            // 
            // btnResumen
            // 
            this.btnResumen.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.btnResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResumen.Location = new System.Drawing.Point(0, 258);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnResumen.Size = new System.Drawing.Size(239, 36);
            this.btnResumen.TabIndex = 10;
            this.btnResumen.Values.Image = global::Sistema_de_Prestamos.Properties.Resources.Planilla;
            this.btnResumen.Values.Text = " Resumen";
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.btnInforme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInforme.Location = new System.Drawing.Point(0, 222);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnInforme.Size = new System.Drawing.Size(239, 36);
            this.btnInforme.TabIndex = 9;
            this.btnInforme.Values.Image = global::Sistema_de_Prestamos.Properties.Resources.informe;
            this.btnInforme.Values.Text = " Estado Prestamo";
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 212);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(239, 10);
            this.Separador.TabIndex = 8;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 525);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnCerrarSesion.Size = new System.Drawing.Size(239, 36);
            this.btnCerrarSesion.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassBottom;
            this.btnCerrarSesion.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCerrarSesion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCerrarSesion.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCerrarSesion.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnCerrarSesion.StateNormal.Back.Color1 = System.Drawing.Color.Firebrick;
            this.btnCerrarSesion.StateNormal.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btnCerrarSesion.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Values.Image = global::Sistema_de_Prestamos.Properties.Resources.salir;
            this.btnCerrarSesion.Values.Text = " Cerrar Sesion";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.btnCalculadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculadora.Location = new System.Drawing.Point(0, 176);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnCalculadora.Size = new System.Drawing.Size(239, 36);
            this.btnCalculadora.TabIndex = 5;
            this.btnCalculadora.Values.Image = global::Sistema_de_Prestamos.Properties.Resources.calcular;
            this.btnCalculadora.Values.Text = " Calculadora";
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.Location = new System.Drawing.Point(0, 140);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnClientes.Size = new System.Drawing.Size(239, 36);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Values.Image = global::Sistema_de_Prestamos.Properties.Resources.audiencia;
            this.btnClientes.Values.Text = " Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // UsuarioIconoNombre
            // 
            this.UsuarioIconoNombre.Controls.Add(this.NombreUsuario);
            this.UsuarioIconoNombre.Controls.Add(this.panel1);
            this.UsuarioIconoNombre.Controls.Add(this.ImagenPerfilUsuario);
            this.UsuarioIconoNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsuarioIconoNombre.Location = new System.Drawing.Point(0, 0);
            this.UsuarioIconoNombre.Name = "UsuarioIconoNombre";
            this.UsuarioIconoNombre.Size = new System.Drawing.Size(239, 140);
            this.UsuarioIconoNombre.TabIndex = 0;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.NombreUsuario.Controls.Add(this.lblNombreUsuario);
            this.NombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreUsuario.Location = new System.Drawing.Point(0, 100);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(239, 30);
            this.NombreUsuario.TabIndex = 10;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = false;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblNombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.lblNombreUsuario.Size = new System.Drawing.Size(239, 30);
            this.lblNombreUsuario.StateCommon.TextColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Text = "Usuario";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 10);
            this.panel1.TabIndex = 9;
            // 
            // ImagenPerfilUsuario
            // 
            this.ImagenPerfilUsuario.BackColor = System.Drawing.Color.Transparent;
            this.ImagenPerfilUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagenPerfilUsuario.ErrorImage = global::Sistema_de_Prestamos.Properties.Resources.usuario_512x512;
            this.ImagenPerfilUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPerfilUsuario.Image")));
            this.ImagenPerfilUsuario.InitialImage = global::Sistema_de_Prestamos.Properties.Resources.usuario_512x512;
            this.ImagenPerfilUsuario.Location = new System.Drawing.Point(0, 0);
            this.ImagenPerfilUsuario.Name = "ImagenPerfilUsuario";
            this.ImagenPerfilUsuario.Size = new System.Drawing.Size(239, 100);
            this.ImagenPerfilUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagenPerfilUsuario.TabIndex = 0;
            this.ImagenPerfilUsuario.TabStop = false;
            this.ImagenPerfilUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagenPerfilUsuario_Paint);
            // 
            // PanelSelect
            // 
            this.PanelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSelect.Location = new System.Drawing.Point(239, 0);
            this.PanelSelect.Name = "PanelSelect";
            this.PanelSelect.Size = new System.Drawing.Size(545, 561);
            this.PanelSelect.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelSelect);
            this.Controls.Add(this.Botones);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Asistencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Botones.ResumeLayout(false);
            this.UsuarioIconoNombre.ResumeLayout(false);
            this.NombreUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfilUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Botones;
        private System.Windows.Forms.Panel UsuarioIconoNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCalculadora;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClientes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrarSesion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInforme;
        private System.Windows.Forms.Panel Separador;
        private System.Windows.Forms.Panel NombreUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblNombreUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImagenPerfilUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfiguracion;
        private System.Windows.Forms.Panel SeparadorPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnResumen;
        private System.Windows.Forms.Panel PanelSelect;
    }
}