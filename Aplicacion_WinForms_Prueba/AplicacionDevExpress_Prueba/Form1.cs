using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicacionDevExpress_Prueba
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAS HECHO CLICK");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (Fecha1.Value > Fecha2.Value) {
                //    MessageBox.Show("La fecha 1 debe ser menor a la fecha 2");
                //}

                //int dias = Fecha2.Value.Day - Fecha1.Value.Day;
                //int mes = Fecha2.Value.Month - Fecha1.Value.Month;
                //int año = Fecha2.Value.Year - Fecha1.Value.Year;

                //if (Fecha1.Value.AddDays(dias) > Fecha2.Value ) {
                //    dias--;
                //}
                //if (Fecha1.Value.AddMonths(mes) > Fecha2.Value)
                //{
                //    mes--;
                //}
                //if (Fecha1.Value.AddYears(año) > Fecha2.Value)
                //{
                //    año--;
                //}


                if (Fecha1.Value > Fecha2.Value)
                {
                    MessageBox.Show("La fecha 1 debe ser menor a la fecha 2");
                    return;
                }
                else
                {
                    TimeSpan calcularDias = Fecha2.Value - Fecha1.Value; ;
                    int totalDias = calcularDias.Days;
                    labelTotal.Text = "Total de dias = " + totalDias.ToString();
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
