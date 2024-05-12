using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorCeceña
{
    public partial class Form1 : Form
    {
        private AnalizadorLexico analizadorLexico = new AnalizadorLexico();
        private AnalizadorSintactico analizadorSintactico = new AnalizadorSintactico();
        private List<Token> tokens;
        string codigo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            this.openFileDialog1.Title = "Abrir Archivo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                {
                    try
                    {

                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            // Lee el contenido del archivo y lo muestra en el TextBox txtFile
                            txtFile.Text = sr.ReadToEnd();
                            codigo = txtFile.Text;
                        }
                        // Habilita el botón btnLexico
                        btnLexico.Enabled = true;
                        btnSintactico.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLexico.Enabled = false;
            btnSintactico.Enabled = false;
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
           
            string resultado = analizadorLexico.Analizar(codigo);
            txtTokens.Text = resultado;
            string errores = analizadorLexico.GetErrores();
            txtErrores.Text = errores;
            string tablaSimbolos = analizadorLexico.GetTablaSimbolos();
            txtSimbolos.Text = tablaSimbolos;

            tokens = analizadorLexico.GetTokens();

            if (errores.Equals(""))
            {
                txtErrores.Text = "No se encontraron errores léxicos";
                btnSintactico.Enabled = true;
            }
        }

        private void btnSintactico_Click(object sender, EventArgs e)
        {
            txtErrores.Clear();

            // Verificar si hay tokens para analizar sintácticamente
            if (tokens != null)
            {
                analizadorSintactico.Analizar(tokens, analizadorLexico.GetIdentificadores());
                string errores = analizadorSintactico.GetErroresSintacticos();
                txtErrores.Text = errores;
                txtSimbolos.Text = analizadorSintactico.GetTablaSimbolos();

                if (errores.Equals(""))
                {
                    txtErrores.Text = "No se encontraron errores sintácticos";
                }
            }
            else
            {
                txtErrores.Text = "No se han generado tokens para analizar sintácticamente.";
            }
        }
    }
}
