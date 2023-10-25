using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playfair;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class PlayfairCipherTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            // Arrange
            PlayfairCipher encryp = new PlayfairCipher("Esta es mi primera prueba para las pruebas unitarias", "hola", null);

            // Act
            string textoCifrado = encryp.Encrypt();

            // Assert
            Assert.AreEqual("MXYFMXNKKUKNDSBNSQGLBNOTBALTKUSGHBTQPKYFQKLT", textoCifrado);

        }

        [TestMethod()]
        public void Encrypt_WithInvalidCharactersInText_RemovesInvalidCharacters()
        {
            // Arrange
            PlayfairCipher encryp = new PlayfairCipher("H@LLO", "hola", null);

            // Act
            string textoCifrado = encryp.Encrypt();

            // Assert
            Assert.AreEqual("OAAL", textoCifrado);
        }

        [TestMethod()]
        public void Encrypt_WithEmptyKey_ReturnsEmptyString()
        {
            // Arrange
            PlayfairCipher encryp = new PlayfairCipher("", "HELLO", null);

            // Act
            string textoCifrado = encryp.Encrypt();

            // Assert
            Assert.AreEqual("", textoCifrado);
        }

        [TestMethod()]
        public void DecryptTest()
        {
            // Arrange
            PlayfairCipher decryp = new PlayfairCipher(null, "HOLA", "MXYFMXNKKUKNDSBNSQGLBNOTBALTKUSGHBTQPKYFQKLT");

            // Act
            string textoDescifrado = decryp.Decrypt();

            // Assert
            Assert.AreEqual("ESTAESMIPRIMERAPRUEBAPARALASPRUEBASUNITARIAS", textoDescifrado);
        }

        [TestMethod()]
        public void Decrypt_WithEmptyKey_ReturnsPlainText()
        {
            // Arrange
            PlayfairCipher decryp = new PlayfairCipher(null, "HELLO", "");

            // Act
            string textoDescifrado = decryp.Decrypt();

            // Assert
            Assert.AreEqual("", textoDescifrado);
        }

        [TestMethod()]
        public void Decrypt_WithKeyContainingSpecialCharacters_RemovesSpecialCharactersFromKey()
        {
            // Arrange
            PlayfairCipher decryp = new PlayfairCipher(null, "HOLA", "O$LA@B");

            // Act
            string textoDescifrado = decryp.Decrypt();

            // Assert
            Assert.AreEqual("HOLA", textoDescifrado);
        }
    }
}