using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void btProcesar_Click(object sender, EventArgs e)
        {
            List<string> patentes = new List<string>
            {
                "OXY333", "OYZ 013", "AAA 123", "BCD-456", "AB 123 CD", "YZ5432", "QW 345 ABC"
            };

            IProcesable procesar;

            if (rbString.Checked)
            {
                procesar = new StringProcesableImpl();
            }
            else if (rbRegex.Checked)
            {
                procesar = new RegexProcesableImpl();
            }
            else
            {
                MessageBox.Show("Seleccione alguna opción");
                return;
            }

            tbVer.Clear();
            foreach (string patente in patentes)
            {
                string descripcion = procesar.Procesar(patente, out string patenteFormateada);

                tbVer.Text += $"Patente: {patenteFormateada} ({descripcion}) \r\n";
            }
        }
    }
}
