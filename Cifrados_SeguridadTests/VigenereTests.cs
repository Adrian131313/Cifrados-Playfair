using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playfair;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playfair.Tests
{
    [TestClass()]
    public class VigenereTests
    {
        [TestMethod()]
        public void CifrarTest()
        {

            Vigenere encryptor = new Vigenere("holamundo", "hola");
          
            // Act (acción)
            string textoCifrado = encryptor.Cifrar();

            // Assert (verificación)
            Assert.AreEqual("ñdvasjxdv", textoCifrado);

        }

        [TestMethod]
        public void MetodoDePrueba_ControlEspacios ()
        {
            Vigenere encryptor = new Vigenere("la diabetes es una enfermedad metabolica cronica caracterizada por niveles elevados de glucosa en sangre  que con el tiempo conduce a daños graves en el corazon los vasos sanguineos los ojos los riñones y los nervios", "diabetes");

            // Act (acción)
            string textoCifrado = encryptor.Cifrar();

            // Assert (verificación)
            Assert.AreEqual("ñi djeuimha et yge wpnespxhsg teueusdlka dviqafi cbvtgmhziaewe irz njzxowv mlfzthhv le hoñghvi eñ wtqyum  qvi vsf hs tjifth fwneyvi s giñpw zvsyms fq xo urzaasg ohv datsm wspñujqxsl ñws pniw dra rjriqwv g lpw gikypot", textoCifrado);
        }
    }
}