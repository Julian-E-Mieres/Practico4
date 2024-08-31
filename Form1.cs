using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Limpiar el listbox antes de agregar nuevos items
            if (ValidacionEntradas(textBoxDesde.Text, textBoxHasta.Text))
            {
                int valorDesde = int.Parse(textBoxDesde.Text);
                int valorHasta = int.Parse(textBoxHasta.Text);

                for (int i = valorDesde; i <= valorHasta; i++)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }

        private bool ValidacionEntradas(string desde, string hasta) //Funcion que valida los texbox antes de realizar alguna accion
        {
            if (string.IsNullOrWhiteSpace(desde) || string.IsNullOrWhiteSpace(hasta))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(desde, out _) || !int.TryParse(hasta, out _))
            {
                MessageBox.Show("Por favor, ingrese solo números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BNumPares_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear(); //Limpiar el listbox antes de agregar nuevos items
            if (ValidacionEntradas(textBoxDesde.Text, textBoxHasta.Text))
            {
                int valorDesde = int.Parse(textBoxDesde.Text);
                int valorHasta = int.Parse(textBoxHasta.Text);

                for (int i = valorDesde; i <= valorHasta; i++)
                {
                    //Controlamos que los numeros listados solo sean los pares
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
            }

        }

        private void BNumImpares_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear(); //Limpiar el listbox antes de agregar nuevos items
            if (ValidacionEntradas(textBoxDesde.Text, textBoxHasta.Text))
            {
                int valorDesde = int.Parse(textBoxDesde.Text);
                int valorHasta = int.Parse(textBoxHasta.Text);

                for (int i = valorDesde; i <= valorHasta; i++)
                {
                    //Controlamos que los numeros listados solo sean los impares
                    if (i % 2 != 0)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
            }

        }

        private void BNumPrimos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos items

            if (ValidacionEntradas(textBoxDesde.Text, textBoxHasta.Text))
            {
                int valorDesde = int.Parse(textBoxDesde.Text);
                int valorHasta = int.Parse(textBoxHasta.Text);

                for (int i = valorDesde; i <= valorHasta; i++)
                {
                    if (EsPrimo(i))
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false; // Los números menores o iguales a 1 no son primos
            if (numero == 2) return true;  // 2 es el único número par primo

            // Verificar la divisibilidad desde 2 hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false; // Si es divisible por algún número, no es primo
            }

            return true; // Si no se encontró ningún divisor, es primo
        }

       

        private void BGenerar_Click(object sender, EventArgs e)
        {
            // Limpiar cualquier serie existente en el Chart
            chart.Series.Clear();  // Aquí BGenerarGrafica se refiere al Chart

            // Crear una nueva serie
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Números Generados");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Line, Pie.

            // Agregar los valores del ListBox al Chart
            foreach (var item in listBox1.Items)
            {
                int numero = int.Parse(item.ToString());
                series.Points.AddY(numero);
            }

            // Agregar la serie al Chart
            chart.Series.Add(series);


        }
    }
}
