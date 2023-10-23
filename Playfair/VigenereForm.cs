using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Playfair
{
    public partial class VigenereForm : Form
    {
        public VigenereForm()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // Configura las propiedades del OpenFileDialog
            abrirtxtocifrado.Filter = "Archivos de texto (*.txt)|*.txt";
            abrirtxtocifrado.Title = "Seleccionar archivo de texto";

            // Abre el diálogo para seleccionar un archivo
            if (abrirtxtocifrado.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = abrirtxtocifrado.FileName;

                try
                {
                    // Lee el contenido del archivo y lo carga en el TextBox
                    string contenido = File.ReadAllText(filePath);
                    txt_CifradoD.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al abrir el archivo
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Configura las propiedades del OpenFileDialog
            abrirtxtFrase.Filter = "Archivos de texto (*.txt)|*.txt";
            abrirtxtFrase.Title = "Seleccionar archivo de texto";

            // Abre el diálogo para seleccionar un archivo
            if (abrirtxtFrase.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = abrirtxtFrase.FileName;

                try
                {
                    // Lee el contenido del archivo y lo carga en el TextBox
                    string contenido = File.ReadAllText(filePath);
                    txt_fraseC.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al abrir el archivo
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cifrar_Click(object sender, EventArgs e)
        {
            string textoSinCifrar = txt_fraseC.Text;
            string clave = txt_claveFraC.Text;

            if (string.IsNullOrWhiteSpace(textoSinCifrar) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Es necesario que ingrese datos a los campos de texto para poder hacer la encriptacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la operación si faltan datos
            }



            Vigenere encryptor = new Vigenere(textoSinCifrar, clave);
            string textoCifrado = encryptor.Cifrar();

            encryptor.TextoCifrado = textoCifrado;

            txt_FraseCriptoC.Text = textoCifrado;

        }

        private void btn_descifrar_Click(object sender, EventArgs e)
        {
            string textoCifrado = txt_CifradoD.Text;
            string clave = txt_claveCifraD.Text;

            if (string.IsNullOrWhiteSpace(textoCifrado) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Es necesario que ingrese datos a los campos de texto para poder hacer la desencriptacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la operación si faltan datos
            }



            Vigenere encryptor = new Vigenere("", clave); // Inicializar con texto vacío
            encryptor.TextoCifrado = textoCifrado;
            string textoDescifrado = encryptor.Descifrar();

            txt_fraseDesifrada.Text = textoDescifrado;
        }

        private void VigenereForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_CifradoD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardarCifrado_Click(object sender, EventArgs e)
        {
            guardarCifrado.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            guardarCifrado.DefaultExt = "txt";
            guardarCifrado.Title = "Guardar archivo de texto";

            if (guardarCifrado.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = guardarCifrado.FileName;

                try
                {
                    // Obtiene el contenido del TextBox
                    string contenido = txt_FraseCriptoC.Text;

                    // Guarda el contenido en el archivo
                    File.WriteAllText(filePath, contenido);

                    MessageBox.Show("Archivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al guardar el archivo
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_GuardarFrase_Click(object sender, EventArgs e)
        {
            guardarFrase.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            guardarFrase.DefaultExt = "txt";
            guardarFrase.Title = "Guardar archivo de texto";

            if (guardarFrase.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = guardarFrase.FileName;

                try
                {
                    // Obtiene el contenido del TextBox
                    string contenido = txt_fraseDesifrada.Text;

                    // Guarda el contenido en el archivo
                    File.WriteAllText(filePath, contenido);

                    MessageBox.Show("Archivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al guardar el archivo
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
