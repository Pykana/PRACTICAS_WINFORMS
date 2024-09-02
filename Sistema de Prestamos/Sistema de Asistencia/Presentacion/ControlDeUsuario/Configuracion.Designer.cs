namespace Sistema_de_Prestamos.Presentacion
{
    partial class Configuracion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SeparadorIzquierdo = new System.Windows.Forms.Panel();
            this.SeparadorDerecho = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelPrincipalConfiguracion = new System.Windows.Forms.Panel();
            this.ParteDatosMostrarEditar = new System.Windows.Forms.Panel();
            this.btnSubirFoto = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ParteImagenUsuario = new System.Windows.Forms.Panel();
            this.Limitador2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Limitador = new System.Windows.Forms.Panel();
            this.SubirArchivoFoto = new System.Windows.Forms.OpenFileDialog();
            this.PanelPrincipalConfiguracion.SuspendLayout();
            this.ParteDatosMostrarEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeparadorIzquierdo
            // 
            this.SeparadorIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SeparadorIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.SeparadorIzquierdo.Name = "SeparadorIzquierdo";
            this.SeparadorIzquierdo.Size = new System.Drawing.Size(50, 561);
            this.SeparadorIzquierdo.TabIndex = 0;
            // 
            // SeparadorDerecho
            // 
            this.SeparadorDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeparadorDerecho.Location = new System.Drawing.Point(495, 0);
            this.SeparadorDerecho.Name = "SeparadorDerecho";
            this.SeparadorDerecho.Size = new System.Drawing.Size(50, 561);
            this.SeparadorDerecho.TabIndex = 1;
            // 
            // PanelPrincipalConfiguracion
            // 
            this.PanelPrincipalConfiguracion.Controls.Add(this.ParteDatosMostrarEditar);
            this.PanelPrincipalConfiguracion.Controls.Add(this.ParteImagenUsuario);
            this.PanelPrincipalConfiguracion.Controls.Add(this.Limitador2);
            this.PanelPrincipalConfiguracion.Controls.Add(this.Limitador);
            this.PanelPrincipalConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipalConfiguracion.Location = new System.Drawing.Point(50, 0);
            this.PanelPrincipalConfiguracion.Name = "PanelPrincipalConfiguracion";
            this.PanelPrincipalConfiguracion.Size = new System.Drawing.Size(445, 561);
            this.PanelPrincipalConfiguracion.TabIndex = 2;
            // 
            // ParteDatosMostrarEditar
            // 
            this.ParteDatosMostrarEditar.Controls.Add(this.btnSubirFoto);
            this.ParteDatosMostrarEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParteDatosMostrarEditar.Location = new System.Drawing.Point(0, 145);
            this.ParteDatosMostrarEditar.Name = "ParteDatosMostrarEditar";
            this.ParteDatosMostrarEditar.Size = new System.Drawing.Size(445, 396);
            this.ParteDatosMostrarEditar.TabIndex = 3;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Location = new System.Drawing.Point(233, 344);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(206, 46);
            this.btnSubirFoto.TabIndex = 0;
            this.btnSubirFoto.Values.Text = "Prueba Subir Archivo";
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // ParteImagenUsuario
            // 
            this.ParteImagenUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ParteImagenUsuario.Location = new System.Drawing.Point(0, 20);
            this.ParteImagenUsuario.Name = "ParteImagenUsuario";
            this.ParteImagenUsuario.Size = new System.Drawing.Size(445, 125);
            this.ParteImagenUsuario.TabIndex = 2;
            // 
            // Limitador2
            // 
            this.Limitador2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Limitador2.Location = new System.Drawing.Point(0, 541);
            this.Limitador2.Name = "Limitador2";
            this.Limitador2.Size = new System.Drawing.Size(445, 20);
            this.Limitador2.TabIndex = 1;
            // 
            // Limitador
            // 
            this.Limitador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Limitador.Location = new System.Drawing.Point(0, 0);
            this.Limitador.Name = "Limitador";
            this.Limitador.Size = new System.Drawing.Size(445, 20);
            this.Limitador.TabIndex = 0;
            // 
            // SubirArchivoFoto
            // 
            this.SubirArchivoFoto.FileName = "SubirArchivoFoto";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.PanelPrincipalConfiguracion);
            this.Controls.Add(this.SeparadorDerecho);
            this.Controls.Add(this.SeparadorIzquierdo);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(545, 561);
            this.PanelPrincipalConfiguracion.ResumeLayout(false);
            this.ParteDatosMostrarEditar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SeparadorIzquierdo;
        private System.Windows.Forms.FlowLayoutPanel SeparadorDerecho;
        private System.Windows.Forms.Panel PanelPrincipalConfiguracion;
        private System.Windows.Forms.FlowLayoutPanel Limitador2;
        private System.Windows.Forms.Panel Limitador;
        private System.Windows.Forms.Panel ParteImagenUsuario;
        private System.Windows.Forms.Panel ParteDatosMostrarEditar;
        private System.Windows.Forms.OpenFileDialog SubirArchivoFoto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubirFoto;
    }
}
