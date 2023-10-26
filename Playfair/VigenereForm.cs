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

        private void btn_cifrar_Click(object sender, EventArgs e)
        {
            string textoSinCifrar = txtFraseC.Text;
            string clave = txtClaveFraC.Text;
            //controla que no se dejen textbox vacios 
            if (string.IsNullOrWhiteSpace(textoSinCifrar) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Es necesario que ingrese datos a los campos de texto para poder hacer la encriptacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la operación si faltan datos
            }
            if (!clave.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese solo letras en el campo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la operación si se ingresan números u otros caracteres
            }


            // aqui se hace referencia a vigenere la clase donde estan los metodos y los atributos para que las variables
            // locales pasen la informacion y el formulario pueda utilizar los metodos 
            Vigenere metodosVigenere = new Vigenere(textoSinCifrar, clave, null);
            string textoCifrado = metodosVigenere.Cifrar();

            metodosVigenere.TextoCifrado = textoCifrado;

            txtFraseCriptoC.Text = textoCifrado;

        }


        private void btn_descifrar_Click(object sender, EventArgs e)
        {
            string textoCifrado = txtCifradoD.Text;
            string clave = txtClaveCifraD.Text;
            // se controla que los txt del desifrado no esten vacios 

            if (string.IsNullOrWhiteSpace(textoCifrado) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Es necesario que ingrese datos a los campos de texto para poder hacer la desencriptacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la operación si faltan datos
            }

            if (!clave.All(char.IsLetter))
            {
                MessageBox.Show("Ingrese solo letras en el campo clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la operación si se ingresan números u otros caracteres
            }



            Vigenere metodosVigenere = new Vigenere("", clave, null); // Inicializar con texto vacío
            metodosVigenere.TextoCifrado = textoCifrado;
            string textoDescifrado = metodosVigenere.Descifrar();

            txtFraseDesifrada.Text = textoDescifrado;
        }



        //el boton que hara el guardado de el cifrado con ayuda del saveFiledialog llamado(guardarCifrado)
        private void btn_guardarCifrado_Click(object sender, EventArgs e)
        {
            //aca se le da el formato al savefiledialog (guardarCifrado) se le pone que lo guarde en formato txt
            guardarCifrado.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";// se configura un filtro que permite al usuario seleccionar archivos de texto con la extensión ".txt" o cualquier tipo de archivo (".")
            guardarCifrado.DefaultExt = "txt";//se utilizará "txt" como extensión predeterminada.
            guardarCifrado.Title = "Guardar archivo de texto";//Esta línea establece el título del diálogo de guardar archivos

            if (guardarCifrado.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = guardarCifrado.FileName;

                try
                {
                    // Obtiene el contenido del TextBox
                    string contenido = txtFraseCriptoC.Text;

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
            //aca se utiliza las misma configuracione que para el guardarCifrado
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
                    string contenido = txtFraseDesifrada.Text;

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

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAbrirCifrado_Click(object sender, EventArgs e)
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
                    // Lee el contenido del archivo y lo pone en el TextBox
                    string contenido = File.ReadAllText(filePath);
                    txtCifradoD.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al abrir el archivo mostrara el mensaje 
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAbrirFrase_Click(object sender, EventArgs e)
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
                    txtFraseC.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al abrir el archivo
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
