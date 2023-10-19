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
            string key = txtUserKey.Text; // Reemplaza con tu clave
            playfairCipher = new PlayfairCipher(key);

            string plainText = txtInput.Text;
            string encryptedText = playfairCipher.Encrypt(plainText);

            // Muestra el texto cifrado en la interfaz de usuario o gu�rdalo en un archivo.
            txtEncryptedOutput.Text = encryptedText;
        }

        private void btnShowMatrix_Click(object sender, EventArgs e)
        {
            if (playfairCipher == null)
            {
                MessageBox.Show("Primero debes establecer una clave.");
                return;
            }

            // Llama al m�todo para obtener la representaci�n de la matriz del alfabeto.
            string matrixAsString = playfairCipher.GetPlayfairMatrixAsString();

            // Supongamos que tienes un control TextBox llamado txtMatrixDisplay en tu interfaz de usuario.
            txtMatrix.Text = matrixAsString;
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            if (playfairCipher == null)
            {
                MessageBox.Show("Primero debes cifrar un texto.");
                return;
            }

            string encryptedText = txtEncryptedOutput.Text;
            string decryptedText = playfairCipher.Decrypt(encryptedText);

            // Muestra el texto descifrado en la interfaz de usuario o gu�rdalo en un archivo.
            txtDecryptedOutput.Text = decryptedText;
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            string userKey = txtUserKey.Text; // Obtiene la clave ingresada por el usuario desde el cuadro de texto

            // Realiza validaci�n de la clave ingresada.
            if (string.IsNullOrWhiteSpace(userKey) || !IsValidKey(userKey))
            {
                MessageBox.Show("La clave ingresada no es v�lida. Aseg�rate de que solo contenga letras y no est� vac�a.", "Error de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se crea la instancia de PlayfairCipher si la clave no es v�lida.
            }

            // Crea una instancia de PlayfairCipher con la clave proporcionada.
            playfairCipher = new PlayfairCipher(userKey);

            // La instancia de PlayfairCipher ahora est� lista para su uso.
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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
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

                // Ahora puedes utilizar fileContent (el contenido del archivo) para cifrar o descifrar seg�n sea necesario.
                // Ejemplo de cifrado:
                if (playfairCipher != null)
                {
                    string encryptedText = playfairCipher.Encrypt(fileContent);
                    txtEncryptedOutput.Text = encryptedText;
                }
                // Ejemplo de descifrado:
                // if (playfairCipher != null)
                // {
                //     string decryptedText = playfairCipher.Decrypt(fileContent);
                //     txtDecryptedOutput.Text = decryptedText;
                // }
            }

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}