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
    public partial class Login : Form
    {
        private DB_Entities data = new DB_Entities();
        private int FlagActivo = 0;
        private LoginControl loginControl;
        private RegistroControl registroControl;

        public Login(int FlagActivo)
        {
            InitializeComponent();
            this.FlagActivo = FlagActivo;
        }

        private void Login_Load(object sender, EventArgs eventArgs)
        {
            loginControl = new LoginControl();
            loginControl.Dock = DockStyle.Fill;
            loginControl.SwitchToRegister += (s, args) => {
                MostrarRegistroControl();
            };

            registroControl = new RegistroControl();
            registroControl.Dock = DockStyle.Fill;
            registroControl.SwitchToLogin += (s, args) => {
                MostrarLoginControl();
            };

            if (FlagActivo == 0)
            {
                PanelControl.Controls.Add(loginControl);
            }
            else
            {
                PanelControl.Controls.Add(registroControl);
            }
        }


        private void MostrarLoginControl()
        {
            PanelControl.Controls.Clear();
            PanelControl.Controls.Add(loginControl);
        }

        private void MostrarRegistroControl()
        {
            PanelControl.Controls.Clear();
            PanelControl.Controls.Add(registroControl);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
