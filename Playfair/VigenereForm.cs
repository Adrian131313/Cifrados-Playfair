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

        //boton para abrir un txt de un texto cifrado
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
                    // Lee el contenido del archivo y lo pone en el TextBox
                    string contenido = File.ReadAllText(filePath);
                    txt_CifradoD.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al abrir el archivo mostrara el mensaje 
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //boton para abir un txt de un texto sin cifrar 
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

            txt_FraseCriptoC.Text = textoCifrado;

        }


        private void btn_descifrar_Click(object sender, EventArgs e)
        {
            string textoCifrado = txt_CifradoD.Text;
            string clave = txt_claveCifraD.Text;
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

            txt_fraseDesifrada.Text = textoDescifrado;
        }
        private void VigenereForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_CifradoD_TextChanged(object sender, EventArgs e)
        {

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

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        
    }
}
