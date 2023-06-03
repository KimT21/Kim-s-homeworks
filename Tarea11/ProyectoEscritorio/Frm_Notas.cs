using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class Frm_Notas : Form
    {
        public Frm_Notas()
        {
            InitializeComponent();
        }

        private void Frm_Notas_Load(object sender, EventArgs e)
        {

        }
        #region atributos 

        #endregion
        public void Limpiar()
        {
            textBox2.Clear();
        }
        private void btnLimpiar(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string notaSelect = txtNotaSeleccionada.Text;
            txtNotaSeleccionada.Clear();
            if (notaSelect != "")
            {
                string texto = textBox2.Text;
                int indiceIni = texto.IndexOf(notaSelect);
                int indiceFi = indiceIni + notaSelect.Length;
                if (indiceIni != -1)
                {
                    string newText = texto.Remove(indiceIni, indiceFi - indiceIni);
                    textBox2.Clear();
                    textBox2.AppendText(newText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = txtNota.Text + "\r\n";
            textBox2.AppendText(text);
            txtNota.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNotaSeleccionada_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text != "")
            {
                double suma = 0;
                int cant = 0;
                List<double> notas = new List<double>();
                string[] lineas = txtNota.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lineas.Length; i++)
                {
                    string linea = lineas[i];
                    if (double.TryParse(linea, out double nota))
                    {
                        notas.Add(nota);
                    }
                }
                for (int i=0; i < notas.Count; i++)
                {
                    suma += notas[i];
                    cant++;
                }
                double promedio= suma/cant;
                String estado="";
                if (suma >= 70)
                {
                    estado = "El estudiante aprobo con una nota de: " + suma;
                }

                else
                {
                    estado = "El estudiante no aprobo con una nota de: " + suma.ToString();
                }
                textBox4.AppendText("El promedio de las notas es de: " + promedio.ToString()+"\n"+estado);

            }
            else
            {
                textBox4.Clear();
                textBox4.AppendText("No hay notas disponibles");
            }
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
