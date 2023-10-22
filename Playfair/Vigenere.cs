using Cifrados_Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Playfair
{
    public class Vigenere : clasePadre
    {
        public Vigenere(string textoSinCifrar, string clave) : base(textoSinCifrar, clave)
        {
        }

        public string TextoCifrado
        {
            get { return textoCifrado; }
            set { textoCifrado = value; }
        }
        

        private char cifrarcaracter(char plainChar, char keyChar)
        {
            if (char.IsLetter(plainChar))
            {
                char baseChar = char.IsUpper(plainChar) ? 'A' : 'a';
                int shift = keyChar - baseChar;
                char encryptedChar = (char)((plainChar - baseChar + shift) % 26 + baseChar);
                return encryptedChar;
            }
            return plainChar;

           
        }

        public string Cifrar()
        {

            textoCifrado = "";
            List<int> posicionEspacios = new List<int>();
            string textoSinEspacios = "";
            for (int i = 0; i < textoSinCifrar.Length; i++)
            {
                if (textoSinCifrar[i] == ' ')
                {
                    posicionEspacios.Add(i);
                }
                else
                {
                    textoSinEspacios += textoSinCifrar[i];
                }
            }
            textoSinEspacios = textoSinEspacios.ToLower(); // Convertir todo el texto a minúsculas
            clave = clave.ToLower();

            for (int i = 0; i < textoSinEspacios.Length; i++)
            {
                char plainChar = textoSinEspacios[i];
                char keyChar = clave[i % clave.Length];
                char encryptedChar = cifrarcaracter(plainChar, keyChar);
                textoCifrado += encryptedChar;
            }

            foreach (int position in posicionEspacios)
            {
                if (position < textoCifrado.Length)
                {
                    textoCifrado = textoCifrado.Insert(position, " ");
                }
            }
            return textoCifrado;
        }

        private char Descifrarcaracter(char cipherChar, char keyChar)
        {
            if (char.IsLetter(cipherChar))
            {
                char baseChar = char.IsUpper(cipherChar) ? 'A' : 'a';
                int shift = keyChar - baseChar;
                char decryptedChar = (char)((cipherChar - baseChar - shift + 26) % 26 + baseChar);
                return decryptedChar;
            }
            return cipherChar;
        }

        public virtual string Descifrar()
        {
            
            textoSinCifrar = "";
            List<int> posicionEspacios = new List<int>(); 
            string textoCifradoSinEspacios = "";
            for (int i = 0; i < textoCifrado.Length; i++)
            {
                if (textoCifrado[i] == ' ')
                {
                    posicionEspacios.Add(i);
                }
                else
                {
                    textoCifradoSinEspacios += textoCifrado[i];
                }
            }
            
            textoCifradoSinEspacios = textoCifradoSinEspacios.ToLower(); // Convertir todo el texto cifrado a minúsculas
            clave = clave.ToLower();
           
            for (int i = 0; i < textoCifradoSinEspacios.Length; i++)
            {
                char plainChar = textoCifradoSinEspacios[i];
                char keyChar = clave[i % clave.Length];
                char encryptedChar = Descifrarcaracter(plainChar, keyChar);
                textoSinCifrar += encryptedChar;
            }


            // Reinsertar los espacios en las posiciones originales
            foreach (int position in posicionEspacios)
            {
                if (position < textoSinCifrar.Length)
                {
                    textoSinCifrar = textoSinCifrar.Insert(position, " ");
                }
            }

            return textoSinCifrar;
        }
       


    }
}

