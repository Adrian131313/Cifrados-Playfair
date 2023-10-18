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
            string key = "MUSTANG"; // Reemplaza con tu clave
            playfairCipher = new PlayfairCipher(key);

            string plainText = txtInput.Text;
            string encryptedText = playfairCipher.Encrypt(plainText);

            // Muestra el texto cifrado en la interfaz de usuario o guárdalo en un archivo.
            txtEncryptedOutput.Text = encryptedText;
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
    }
}