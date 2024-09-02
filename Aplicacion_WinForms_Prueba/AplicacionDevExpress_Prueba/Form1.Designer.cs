namespace AplicacionDevExpress_Prueba
{
    partial class Form1
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
            this.LbEdad1 = new DevExpress.XtraEditors.LabelControl();
            this.Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.LbEdad2 = new DevExpress.XtraEditors.LabelControl();
            this.Fecha2 = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.labelTotal = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LbEdad1
            // 
            this.LbEdad1.Location = new System.Drawing.Point(55, 74);
            this.LbEdad1.Name = "LbEdad1";
            this.LbEdad1.Size = new System.Drawing.Size(39, 16);
            this.LbEdad1.TabIndex = 0;
            this.LbEdad1.Text = "Edad 1";
            // 
            // Fecha1
            // 
            this.Fecha1.CustomFormat = "dd-MM-yyyy";
            this.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha1.Location = new System.Drawing.Point(125, 69);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(137, 23);
            this.Fecha1.TabIndex = 1;
            // 
            // LbEdad2
            // 
            this.LbEdad2.Location = new System.Drawing.Point(55, 150);
            this.LbEdad2.Name = "LbEdad2";
            this.LbEdad2.Size = new System.Drawing.Size(39, 16);
            this.LbEdad2.TabIndex = 2;
            this.LbEdad2.Text = "Edad 2";
            this.LbEdad2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // Fecha2
            // 
            this.Fecha2.CustomFormat = "dd-MM-yyyy";
            this.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha2.Location = new System.Drawing.Point(125, 145);
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.Size = new System.Drawing.Size(137, 23);
            this.Fecha2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(168, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(168, 278);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(98, 16);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total de dias = 0";
            this.labelTotal.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 351);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Fecha2);
            this.Controls.Add(this.LbEdad2);
            this.Controls.Add(this.Fecha1);
            this.Controls.Add(this.LbEdad1);
            this.IconOptions.Image = global::AplicacionDevExpress_Prueba.Properties.Resources.rubik;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Cubico Form";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LbEdad1;
        private System.Windows.Forms.DateTimePicker Fecha1;
        private DevExpress.XtraEditors.LabelControl LbEdad2;
        private System.Windows.Forms.DateTimePicker Fecha2;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private DevExpress.XtraEditors.LabelControl labelTotal;
    }
}

