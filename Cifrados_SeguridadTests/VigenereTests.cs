using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playfair;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            Vigenere Vigenere = new Vigenere("holamundo", "hola", null);
          
            // Act (acción)
            string textoCifrado = Vigenere.Cifrar();

            // Assert (verificación)
            Assert.AreEqual("ñóvasdxdv", textoCifrado);

        }

        [TestMethod]
        public void MetodoDePrueba_ControlEspacios_Cifrado ()
        {
            Vigenere Vigenere = new Vigenere("la diabetes es una enfermedad metabolica cronica " +
                "caracterizada por niveles elevados de glucosa en sangre  que con el tiempo conduce a daños graves en el " +
                "corazon los vasos sanguineos los ojos los riñones y los nervios", "diabetes", null);

            // Act (acción)
            string textoCifrado = Vigenere.Cifrar();

            // Assert (verificación)
            Assert.AreEqual("ñi djeuighá et yae wpnespxhsg teueusólka dvcqáfi cbvtgghziáewe crz njzxowv mlfzthbv le hoigbvi eñ wtqyum  qvi vsü hs tjiütb fwneyvi s giñpw zvsyms fq xo urzaása obv óatsg wspñujqxsf ñws pncw órá rjrcqwv a lpw aieypot", textoCifrado);
        }

        [TestMethod]
        public void MetodoDePrueba_ControlÑCifrado()
        {
            Vigenere Vigenere = new Vigenere("El Ñandu es un animal", "ñandu", null);

            // Act (acción)
            string textoCifrado = Vigenere.Cifrar();

            // Assert (verificación)
            Assert.AreEqual("rl ádbqu qv já azlañl", textoCifrado);
        }

        [TestMethod]
        public void DescifradoTest()
        {
            Vigenere vigenere = new Vigenere( null,"ñandu", "rládbquqvjáazlañl");

            // Act
            string textoDescifrado = vigenere.Descifrar(); // Asegúrate de establecer "textoCifrado", "clave" y "textoSinCifrar" en los valores adecuados antes de llamar a este método.

            // Assert
            Assert.AreEqual("elñanduesunanimal", textoDescifrado);

          
        }

        [TestMethod]
         public void DescifradoTestControl_Acentos()
         {
           
            Vigenere encryptor = new Vigenere(null, "acentos", "eliydzbs fi ítzsbteü vóü aeizhó brvssfjxies");

             // Act (acción)
             string textoDescifrado = encryptor.Descifrar();

             // Assert (verificación)
             Assert.AreEqual("ejemplos de palabras con acento ortográfico", textoDescifrado);
         }

        [TestMethod]
        public void DescifradoTestCntrol_TextoLargo()
        {
            Vigenere vigenere = new Vigenere(null, "empresa", "iy vvqwrew eúe wmtótee gapnxnq fe tatui vejtízv uopá eúe hnmopu jbrpmsr tbr yy vdyco hp üvvfoqmc smwniú érxwrmmávw l fmypúgáevác tsü eo áqáigizá sv teoharzv slká ú bvwsxmb gq fevbxtmb qyp rgfea yyp úiuewtsrh l psó tí uhe wp úsxwnkmí siüejtrzsf");

            
            string textoDescifrado = vigenere.Descifrar();

            // Assert (verificación)
            Assert.AreEqual("en general una empresa también se puede definir como una unidad formada por un grupo de personas bienes materiales y financieros con el objetivo de producir algo o prestar un servicio que cubra una necesidad y por el que se obtengan beneficios", textoDescifrado);
        }

        [TestMethod]
        public void CifrarCaracter_DeberiaCifrar()
        {
            
            Vigenere vigenere = new Vigenere("textoSinCifrar", "clave", "textoCifrado");

            
            char caracterCifrado = vigenere.cifrarcaracter('h', 'h'); 
            
            Assert.AreEqual('ñ', caracterCifrado); 
        }
        [TestMethod]
        public void CifrarCaracter_DeberiaCifrarÑ()
        {

            Vigenere vigenere = new Vigenere("textoSinCifrar", "clave", "textoCifrado");


            char caracterCifrado = vigenere.cifrarcaracter('ñ', 'l');

            Assert.AreEqual('y', caracterCifrado);
        }
        [TestMethod]
        public void CifrarCaracter_DeberiaCifrarAcento()
        {

            Vigenere vigenere = new Vigenere("textoSinCifrar", "clave", "textoCifrado");


            char caracterCifrado = vigenere.cifrarcaracter('ó', 'l');

            Assert.AreEqual('i', caracterCifrado);
        }

        [TestMethod]
        public void DescifrarCaracter_DeberiaDescifrar()
        {

            Vigenere vigenere = new Vigenere("textoSinCifrar", "clave", "textoCifrado");


            char caracterDescifrado = vigenere.Descifrarcaracter('ñ', 'h');

            Assert.AreEqual('h', caracterDescifrado);
        }

        [TestMethod]
        public void DescifrarCaracter_DeberiaDescifrarAcento()
        {

            Vigenere vigenere = new Vigenere("textoSinCifrar", "clave", "textoCifrado");


            char caracterDescifrado = vigenere.Descifrarcaracter('i', 'l');

            Assert.AreEqual('ó', caracterDescifrado);
        }

        [TestMethod]
        public void DescifrarCaracter_DeberiaDescifrarÑ()
        {

            Vigenere vigenere = new Vigenere("textoSinCifrar", "clave", "textoCifrado");


            char caracterDescifrado = vigenere.Descifrarcaracter('y', 'l');

            Assert.AreEqual('ñ', caracterDescifrado);
        }


    }
}