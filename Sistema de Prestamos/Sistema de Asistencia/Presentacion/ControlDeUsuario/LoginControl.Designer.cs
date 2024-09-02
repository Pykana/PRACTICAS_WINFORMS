namespace Sistema_de_Prestamos.Presentacion
{
    partial class LoginControl
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
            this.lblLinkRegistro = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtContrasena = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.txtUsuario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNombre = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lblTituloEmpresa = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.btnIngresar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lblLinkRegistro
            // 
            this.lblLinkRegistro.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.lblLinkRegistro.Location = new System.Drawing.Point(150, 275);
            this.lblLinkRegistro.Name = "lblLinkRegistro";
            this.lblLinkRegistro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.lblLinkRegistro.Size = new System.Drawing.Size(63, 22);
            this.lblLinkRegistro.StateCommon.ShortText.Color1 = System.Drawing.Color.LightCyan;
            this.lblLinkRegistro.StateCommon.ShortText.Color2 = System.Drawing.Color.LightCyan;
            this.lblLinkRegistro.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.lblLinkRegistro.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblLinkRegistro.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblLinkRegistro.TabIndex = 10;
            this.lblLinkRegistro.Values.Text = "Registrate";
            this.lblLinkRegistro.LinkClicked += new System.EventHandler(this.lblLinkRegistro_LinkClicked);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 275);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kryptonLabel1.Size = new System.Drawing.Size(126, 22);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "¿No estas registrado?";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContrasena.Location = new System.Drawing.Point(15, 188);
            this.txtContrasena.MaxLength = 30;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.Size = new System.Drawing.Size(420, 23);
            this.txtContrasena.TabIndex = 13;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.AutoSize = false;
            this.kryptonWrapLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.White;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(15, 173);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(420, 15);
            this.kryptonWrapLabel1.StateCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.White;
            this.kryptonWrapLabel1.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuario.Location = new System.Drawing.Point(15, 150);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(420, 23);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = false;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(15, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(420, 27);
            this.lblNombre.StateCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.StateCommon.TextColor = System.Drawing.Color.White;
            this.lblNombre.Text = "Correo";
            // 
            // lblTituloEmpresa
            // 
            this.lblTituloEmpresa.AutoSize = false;
            this.lblTituloEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblTituloEmpresa.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblTituloEmpresa.Location = new System.Drawing.Point(15, 15);
            this.lblTituloEmpresa.Name = "lblTituloEmpresa";
            this.lblTituloEmpresa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.lblTituloEmpresa.Size = new System.Drawing.Size(420, 108);
            this.lblTituloEmpresa.StateCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpresa.StateCommon.TextColor = System.Drawing.Color.White;
            this.lblTituloEmpresa.Text = "Prestamos";
            this.lblTituloEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.Location = new System.Drawing.Point(292, 217);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(140, 25);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Values.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::Sistema_de_Prestamos.Properties.Resources.FondoNegroCircuito;
            this.Controls.Add(this.lblLinkRegistro);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.kryptonWrapLabel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloEmpresa);
            this.Name = "LoginControl";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(450, 561);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lblLinkRegistro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtContrasena;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblTituloEmpresa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIngresar;
    }
}
