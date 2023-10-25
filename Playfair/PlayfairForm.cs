namespace Playfair
{
    public partial class PlayfairForm : Form
    {
        private PlayfairCipher playfairCipher;

        public PlayfairForm()
        {
            InitializeComponent();
        }

        private void btnCifrado_Click(object sender, EventArgs e)
        {
            string clave = txtUserKey.Text; // Obtiene la clave ingresada por el usuario desde el cuadro de texto
            string textoSinCifrar = txtInput.Text;

            // Realiza validaci�n de la clave ingresada.
            if (string.IsNullOrWhiteSpace(clave) || !IsValidKey(clave))
            {
                MessageBox.Show("La clave ingresada no es v�lida. Aseg�rate de que solo contenga letras y no est� vac�a.", "Error de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se crea la instancia de PlayfairCipher si la clave no es v�lida.
            }
            else
            {
                // Crea una instancia de PlayfairCipher con la clave y el texto sin cifrar
                PlayfairCipher playfairCipher = new PlayfairCipher(textoSinCifrar, clave, null);

                // Obt�n el texto cifrado utilizando la propiedad TextoCifrado
                string textoCifrado = playfairCipher.Encrypt();

                // Muestra el texto cifrado en la interfaz de usuario o gu�rdalo en un archivo.
                txtEncryptedOutput.Text = textoCifrado;

                // Llama al m�todo para obtener la representaci�n de la matriz del alfabeto.
                string matrixAsString = playfairCipher.GetPlayfairMatrixAsString();

                // Supongamos que tienes un control TextBox llamado txtMatrixDisplay en tu interfaz de usuario.
                txtMatrix.Text = matrixAsString;
            }

        }

        private void btnDescifrado_Click(object sender, EventArgs e)
        {
            string clave = txtUserKeyDesc.Text; // Obtiene la clave ingresada por el usuario desde el cuadro de texto
            string textoCifrado = txtDecryptedInput.Text;

            // Realiza validaci�n de la clave ingresada.
            if (string.IsNullOrWhiteSpace(clave) || !IsValidKey(clave))
            {
                MessageBox.Show("La clave ingresada no es v�lida. Aseg�rate de que solo contenga letras y no est� vac�a.", "Error de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se crea la instancia de PlayfairCipher si la clave no es v�lida.
            }
            else
            {
                // Crea una instancia de PlayfairCipher con la clave y el texto cifrado
                PlayfairCipher playfairCipher = new PlayfairCipher(textoCifrado, clave, textoCifrado);

                // Obt�n el texto descifrado utilizando el m�todo Descifrar
                string textoDescifrado = playfairCipher.Decrypt();

                // Muestra el texto descifrado en la interfaz de usuario o gu�rdalo en un archivo.
                txtDecryptedOutput.Text = textoDescifrado;

                // Llama al m�todo para obtener la representaci�n de la matriz del alfabeto.
                string matrixAsString = playfairCipher.GetPlayfairMatrixAsString();

                // Supongamos que tienes un control TextBox llamado txtMatrixDisplay en tu interfaz de usuario.
                txtMatrixDec.Text = matrixAsString;
            }

        }



        // Funci�n para validar la clave (puedes personalizarla seg�n tus requisitos).
        private bool IsValidKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return false;

            // Verifica que la clave solo contenga letras (puedes agregar m�s validaciones si es necesario).
            foreach (char character in key)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }

            return true;
        }


        private void btnOpenFileEnc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Title = "Selecciona un archivo de texto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);

                // Asigna el contenido del archivo al control txtInput.
                txtInput.Text = fileContent;
            }
        }

        private void btnOpenFileDesc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog1.Title = "Selecciona un archivo de texto";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);

                // Asigna el contenido del archivo al control txtDecryptedInput.
                txtDecryptedInput.Text = fileContent;
            }
        }



        private void btnSaveCiphertext_Click(object sender, EventArgs e)
        {
            if (txtEncryptedOutput == null)
            {
                MessageBox.Show("Primero debes cifrar un texto.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto cifrado";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string encryptedText = txtEncryptedOutput.Text;

                try
                {
                    File.WriteAllText(filePath, encryptedText);
                    MessageBox.Show("Texto cifrado guardado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveDesctext_Click(object sender, EventArgs e)
        {
            if (txtDecryptedOutput == null)
            {
                MessageBox.Show("Primero debes descifrar un texto.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto cifrado";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string desencryptedText = txtDecryptedOutput.Text;

                try
                {
                    File.WriteAllText(filePath, desencryptedText);
                    MessageBox.Show("Texto cifrado guardado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PlayfairForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}