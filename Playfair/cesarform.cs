using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cifrados_Seguridad
{
    public partial class cesarform : Form
    {
        private metodos_Cesar cifrador; // Declaración de la instancia
        public cesarform()
        {
            InitializeComponent();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoSinCifrar = txtTexto.Text;
                int clave = int.Parse(txtClave.Text);

                cifrador = new metodos_Cesar(textoSinCifrar, clave);
                string textoCifrado = cifrador.cifrar();

                txtTextoCifrado.Text = textoCifrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cifrar: " + ex.Message);
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    // Lee el contenido del archivo y muestra en txtTexto.
                    string textoLeido = File.ReadAllText(selectedFile);
                    txtTexto.Text = textoLeido;
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoCifrado = txtTextoCifrado.Text;
                int clave = int.Parse(txtClave.Text);

                cifrador = new metodos_Cesar(textoCifrado, clave);
                string textoDescifrado = cifrador.descifrar();

                txtTextoDescifrado.Text = textoDescifrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descifrar: " + ex.Message);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtTextoCifrado.Text = string.Empty;
            txtTextoDescifrado.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           /* // Oculta el formulario actual (Form2)
            this.Hide();

            // Muestra el formulario anterior (Form1)
            FormPrincipal form1 = new FormPrincipal();
            form1.Show();*/
        }

        private void txtTextoCifrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTextoDescifrado_TextChanged(object sender, EventArgs e)
        {

        }
        private void Guardartxt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = saveFileDialog.FileName;
                    string textoCifrado = txtTextoCifrado.Text;

                    // Guarda el texto cifrado en el archivo seleccionado.
                    System.IO.File.WriteAllText(selectedFile, textoCifrado);

                    MessageBox.Show("El archivo se ha guardado exitosamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
