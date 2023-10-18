namespace Playfair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PlayfairCipher playfairCipher;













        private void btnCifrado_Click(object sender, EventArgs e)
        {
            string key = txtUserKey.Text; // Reemplaza con tu clave
            playfairCipher = new PlayfairCipher(key);

            string plainText = txtInput.Text;
            string encryptedText = playfairCipher.Encrypt(plainText);

            // Muestra el texto cifrado en la interfaz de usuario o guárdalo en un archivo.
            txtEncryptedOutput.Text = encryptedText;
        }

        private void btnShowMatrix_Click(object sender, EventArgs e)
        {
            // Asegúrate de tener una instancia válida de PlayfairCipher con la matriz generada.
            PlayfairCipher playfairCipher = new PlayfairCipher(txtUserKey.Text); // Reemplaza "YOUR_KEY" con tu clave.

            // Llama al método para obtener la representación de la matriz del alfabeto.
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

            // Muestra el texto descifrado en la interfaz de usuario o guárdalo en un archivo.
            txtDecryptedOutput.Text = decryptedText;
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
        }


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


    }
}