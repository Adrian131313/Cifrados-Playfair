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


        //llamada a la variable   
        public string TextoCifrado
        {
            get { return textoCifrado; }
            set { textoCifrado = value; }
        }

        //varible alfabeto que se utiliza para asi implementar la ñ
        private const string Alfabeto = "abcdefghijklmnñopqrstuvwxyz";

        //metodo que cifra un carácter de acuerdo a la lógica del cifrado de Vigenère
        //teniendo en cuenta las mayúsculas y minúsculas  
        private char cifrarcaracter(char plainChar, char keyChar)
        {

            //este if verifica si tanto plainChar (lo que se usa para la frase ingresada)como keyChar(la clave)
            //están presentes en el alfabeto definido en la variable Alfabeto. Para garantizar la comparación insensible a mayúsculas y minúsculas, convierte ambos caracteres a minúsculas usando char.ToLower()
            if (Alfabeto.Contains(char.ToLower(plainChar)) && Alfabeto.Contains(char.ToLower(keyChar)))
            {
                bool esMayuscula = char.IsUpper(plainChar);//Esta línea determina si plainChar es una letra mayúscula y almacena el resultado en la variable es Mayuscula(IsUpper)
                int indiceTexto = Alfabeto.IndexOf(char.ToLower(plainChar));//Aquí, se obtiene el índice de plainChar (convertido a minúsculas) en el alfabeto y se almacena en la variable indiceTexto.
                int indiceClave = Alfabeto.IndexOf(char.ToLower(keyChar)); //se obtiene el índice de keyChar(convertido a minúsculas) en el alfabeto y se almacena en la variable indiceClave.
                int indiceCifrado = (indiceTexto + indiceClave) % Alfabeto.Length;//calcula el índice resultante en el alfabeto cifrado sumando los índices de plainChar y keyChar, y luego tomando el módulo del tamaño del alfabeto (para asegurarse de que el índice esté dentro de los límites del alfabeto cifrado).
                return esMayuscula ? char.ToUpper(Alfabeto[indiceCifrado]) : Alfabeto[indiceCifrado];// Dependiendo de si plainChar era mayúscula o minúscula, se devuelve el carácter correspondiente en el alfabeto cifrado en la misma forma de capitalización.
                                                                                                     // Si plainChar era mayúscula, se usa char.ToUpper() para convertir el carácter cifrado a mayúsculas.
            }
            return plainChar;// // Si plainChar o keyChar no están en el alfabeto, se deja sin cambios
        }

        public string Cifrar()
        {

            textoCifrado = "";
            List<int> posicionEspacios = new List<int>();//Crea una lista llamada posicionEspacios para rastrear las posiciones de los espacios en el texto original y mas adelante con esta lista se podran reintegrar los espacios 
            string textoSinEspacios = "";//Esta cadena se utilizará para almacenar el texto original sin espacios.
            for (int i = 0; i < textoSinCifrar.Length; i++)
            {
                if (textoSinCifrar[i] == ' ')//Verifica si el carácter actual es un espacio en blanco.
                {
                    posicionEspacios.Add(i);//Si es un espacio, agrega la posición del espacio a la lista posicionEspacios
                }
                else
                {
                    textoSinEspacios += textoSinCifrar[i];//Si no es un espacio, agrega el carácter a la cadena textoSinEspacios.
                }
            }
            textoSinEspacios = textoSinEspacios.ToLower(); // Convierte todo el texto en textoSinEspacios a minúsculas
            clave = clave.ToLower();//Convierte la clave a minúsculas para asegurarse de que coincida con el formato del texto sin espacios.

            for (int i = 0; i < textoSinEspacios.Length; i++)//itera a través de cada carácter en textoSinEspacios
            {
                char plainChar = textoSinEspacios[i];//Obtiene el carácter actual en textoSinEspacios
                char keyChar = clave[i % clave.Length];//Obtiene el carácter de la clave que corresponde a la posición actual. El operador % se utiliza para asegurarse de que se utilice el carácter correcto de la clave, incluso si el texto es más largo que la clave
                char encryptedChar = cifrarcaracter(plainChar, keyChar);//Llama a la función cifrarcaracter
                textoCifrado += encryptedChar;//Agrega el carácter cifrado a la cadena textoCifrado
            }

            foreach (int position in posicionEspacios)//se utiliza para recorrer las posiciones de los espacios almacenadas en posicionEspacios
            {
                if (position < textoCifrado.Length)
                {
                    textoCifrado = textoCifrado.Insert(position, " ");//Se inserta un espacio en blanco en textoCifrado
                }
            }
            return textoCifrado;//el método devuelve la cadena textoCifrado, que contiene el texto original cifrado.
        }


        //metodo que descifra un carácter de acuerdo a la lógica del cifrado de Vigenère
        //teniendo en cuenta las mayúsculas y minúsculas
        private char Descifrarcaracter(char cipherChar, char keyChar)
        {
            //este if verifica si tanto plainChar (lo que se usa para la frase ingresada)como keyChar(la clave)
            //están presentes en el alfabeto definido en la variable Alfabeto. Para garantizar la comparación insensible a mayúsculas y minúsculas, convierte ambos caracteres a minúsculas usando char.ToLower()
            if (Alfabeto.Contains(char.ToLower(cipherChar)) && Alfabeto.Contains(char.ToLower(keyChar)))
            {
                //utiliza la misma logica que el cifrarcaracter
                bool esMayuscula = char.IsUpper(cipherChar);
                int indiceCifrado = Alfabeto.IndexOf(char.ToLower(cipherChar));
                int indiceClave = Alfabeto.IndexOf(char.ToLower(keyChar));
                int indiceTexto = (indiceCifrado - indiceClave + Alfabeto.Length) % Alfabeto.Length;
                return esMayuscula ? char.ToUpper(Alfabeto[indiceTexto]) : Alfabeto[indiceTexto];
            }
            return cipherChar;
        }

        public virtual string Descifrar()
        {

            textoSinCifrar = "";
            List<int> posicionEspacios = new List<int>(); //Crea una lista llamada posicionEspacios para rastrear las posiciones de los espacios en el texto original y mas adelante con esta lista se podran reintegrar los espacios 
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

