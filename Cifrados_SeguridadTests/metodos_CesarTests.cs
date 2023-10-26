using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cifrados_Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playfair;

namespace Cifrados_Seguridad.Tests
{
    [TestClass()]
    public class metodos_CesarTests
    {
        [TestMethod()]
        public void cifrarTest()
        {
            metodos_Cesar encriptacion = new metodos_Cesar("hola mundo", 5);

            // Act (acción)
            string textoCifrado = encriptacion.cifrar();

            // Assert (verificación)
            Assert.AreEqual("MTQFRZSIT", textoCifrado);
        }

        [TestMethod()]
        public void cifrarTestSinText()
        {
            metodos_Cesar encriptacion = new metodos_Cesar("", 5);

            // Act (acción)
            string textoCifrado = encriptacion.cifrar();

            // Assert (verificación)
            Assert.AreEqual("", textoCifrado);
        }

        [TestMethod()]
        public void cifrarTextConCaracteresEspeciales()
        {
            metodos_Cesar encriptacion = new metodos_Cesar("H@llo", 5);

            // Act (acción)
            string textoCifrado = encriptacion.cifrar();

            // Assert (verificación)
            Assert.AreEqual("MQQT", textoCifrado);
        }

        [TestMethod()]
        public void DecryptTest()
        {
            // Arrange
            metodos_Cesar desencriptacion = new metodos_Cesar("JXYFJXQFUWZJGFUFWFJQIJXHNKWFITIJHJXFW",5);

            // Act
            string textoDescifrado = desencriptacion.descifrar();

            // Assert
            Assert.AreEqual("ESTAESLAPRUEBAPARAELDESCIFRADODECESAR", textoDescifrado);
        }

        [TestMethod()]
        public void DecryptTestSinTexto()
        {
            // Arrange
            metodos_Cesar desencriptacion = new metodos_Cesar("", 5);

            // Act
            string textoDescifrado = desencriptacion.descifrar();

            // Assert
            Assert.AreEqual("", textoDescifrado);
        }

        [TestMethod()]
        public void DescifrarConCaracteresEspeciales()
        {
            // Arrange
            metodos_Cesar desencriptacion = new metodos_Cesar("O$LA@B", 5);

            // Act
            string textoDescifrado = desencriptacion.descifrar();

            // Assert
            Assert.AreEqual("JGVW", textoDescifrado);
        }
    }
}