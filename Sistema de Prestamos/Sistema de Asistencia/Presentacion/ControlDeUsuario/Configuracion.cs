using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Prestamos.Presentacion
{
    public partial class Configuracion : UserControl
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            SubirArchivoFoto.ShowDialog();
        }
    }
}
