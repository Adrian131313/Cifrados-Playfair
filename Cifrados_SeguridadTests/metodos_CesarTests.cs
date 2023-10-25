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
            metodos_Cesar encriptacion = new metodos_Cesar("holamundo", 5);

            // Act (acción)
            string textoCifrado = encriptacion.cifrar();

            // Assert (verificación)
            Assert.AreEqual("anotas el resultado que tendria que salir ", textoCifrado);
            Assert.Fail();
        }
    }
}