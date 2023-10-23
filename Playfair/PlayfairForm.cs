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
            string key = txtUserKey.Text; // Obtiene la clave ingresada por el usuario desde el cuadro de texto

            // Realiza validación de la clave ingresada.
            if (string.IsNullOrWhiteSpace(key) || !IsValidKey(key))
            {
                MessageBox.Show("La clave ingresada no es válida. Asegúrate de que solo contenga letras y no esté vacía.", "Error de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se crea la instancia de PlayfairCipher si la clave no es válida.
            }

            // Crea una instancia de PlayfairCipher con la clave proporcionada.
            playfairCipher = new PlayfairCipher(key);

            // La instancia de PlayfairCipher ahora está lista para su uso.


            string plainText = txtInput.Text;
            string encryptedText = playfairCipher.Encrypt(plainText);

            // Muestra el texto cifrado en la interfaz de usuario o guárdalo en un archivo.
            txtEncryptedOutput.Text = encryptedText;

            // Llama al método para obtener la representación de la matriz del alfabeto.
            string matrixAsString = playfairCipher.GetPlayfairMatrixAsString();

            // Supongamos que tienes un control TextBox llamado txtMatrixDisplay en tu interfaz de usuario.
            txtMatrix.Text = matrixAsString;
        }

        private void btnDescifrado_Click(object sender, EventArgs e)
        {
            string key = txtUserKeyDesc.Text; // Obtiene la clave ingresada por el usuario desde el cuadro de texto

            // Realiza validación de la clave ingresada.
            if (string.IsNullOrWhiteSpace(key) || !IsValidKey(key))
            {
                MessageBox.Show("La clave ingresada no es válida. Asegúrate de que solo contenga letras y no esté vacía.", "Error de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se crea la instancia de PlayfairCipher si la clave no es válida.
            }

            // Crea una instancia de PlayfairCipher con la clave proporcionada.
            playfairCipher = new PlayfairCipher(key);

            // La instancia de PlayfairCipher ahora está lista para su uso.
            string encryptedText = txtDecryptedInput.Text;
            string decryptedText = playfairCipher.Decrypt(encryptedText);

            // Muestra el texto descifrado en la interfaz de usuario o guárdalo en un archivo.
            txtDecryptedOutput.Text = decryptedText;
        }



        /*private void btnDescifrar_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCifrado_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowMatrix_Click(object sender, EventArgs e)
        {
            if (playfairCipher == null)
            {
                MessageBox.Show("Primero debes establecer una clave.");
                return;
            }

            
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            if (playfairCipher == null)
            {
                MessageBox.Show("Primero debes cifrar un texto.");
                return;
            }

            
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            string userKey = txtUserKey.Text; // Obtiene la clave ingresada por el usuario desde el cuadro de texto

            // Realiza validación de la clave ingresada.
            if (string.IsNullOrWhiteSpace(userKey) || !IsValidKey(userKey))
            {
                MessageBox.Show("La clave ingresada no es válida. Asegúrate de que solo contenga letras y no esté vacía.", "Error de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se crea la instancia de PlayfairCipher si la clave no es válida.
            }

            // Crea una instancia de PlayfairCipher con la clave proporcionada.
            playfairCipher = new PlayfairCipher(userKey);

            // La instancia de PlayfairCipher ahora está lista para su uso.
        }*/


        // Función para validar la clave (puedes personalizarla según tus requisitos).
        private bool IsValidKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return false;

            // Verifica que la clave solo contenga letras (puedes agregar más validaciones si es necesario).
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

        /*private void btnOpenFile_Click(object sender, EventArgs e)
        {
            

        }*/

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowMatrix_Click_1(object sender, EventArgs e)
        {

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

                // Ahora puedes utilizar fileContent (el contenido del archivo) para cifrar o descifrar según sea necesario.
                // Ejemplo de cifrado:
                /*if (playfairCipher != null)
                {
                    string encryptedText = playfairCipher.Encrypt(fileContent);
                    txtEncryptedOutput.Text = encryptedText;
                }*/
                // Ejemplo de descifrado:
                // if (playfairCipher != null)
                // {
                //     string decryptedText = playfairCipher.Decrypt(fileContent);
                //     txtDecryptedOutput.Text = decryptedText;
                // }
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

                // Ahora puedes utilizar fileContent (el contenido del archivo) para cifrar o descifrar según sea necesario.
                // Ejemplo de cifrado:
                /*if (playfairCipher != null)
                {
                    string decryptedText = playfairCipher.Decrypt(fileContent);
                    txtDecryptedOutput.Text = decryptedText;
                }*/
                // Ejemplo de descifrado:
                // if (playfairCipher != null)
                // {
                //     string decryptedText = playfairCipher.Decrypt(fileContent);
                //     txtDecryptedOutput.Text = decryptedText;
                // }
            }
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnSaveCiphertext_Click(object sender, EventArgs e)
        {
            if (playfairCipher == null)
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
                    MessageBox.Show("Texto cifrado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveDesctext_Click(object sender, EventArgs e)
        {
            if (playfairCipher == null)
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
                    MessageBox.Show("Texto cifrado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}