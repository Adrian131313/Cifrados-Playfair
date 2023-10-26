using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrados_Seguridad
{
    public class metodos_Cesar : clasePadre
    {
        public int clave;
        public string textoCifrado;
        public metodos_Cesar(string textoSinCifrar, int clave) : base(textoSinCifrar)
        {
            this.clave = clave;
        }
        public string TextoCifrado
        {
            get { return textoCifrado; }
            set { textoCifrado = value; }
        }
        private string RemoveAccentedCharacters(string text)
        {
            // Define los pares de reemplazo para letras acentuadas
            var replacements = new Dictionary<char, char>
    {
        {'Á', 'A'},
        {'Ñ', 'N'},
        {'Í', 'I'},
        {'Ó', 'O'},
        {'Ú', 'U'},
        {'Ü', 'U'},
        {'ñ', 'n'},

        // Agrega más pares según sea necesario
    };

            // Realiza el reemplazo de las letras acentuadas
            foreach (var replacement in replacements)
            {
                text = text.Replace(replacement.Key, replacement.Value);
            }

            return text;
        }

        public string cifrar()
        {
            textoCifrado = ""; // Inicializar la cadena de texto cifrado

            // Normaliza el texto antes de cifrar
            textoSinCifrar = RemoveAccentedCharacters(textoSinCifrar);
            textoSinCifrar = textoSinCifrar.ToUpper(); // Convierte todo el texto a mayúsculas
            textoSinCifrar = new string(textoSinCifrar.Where(char.IsLetter).ToArray()); // Elimina caracteres no alfabéticos

            foreach (char letra in textoSinCifrar)
            {
                if (char.IsLetter(letra)) // Solo cifrar letras
                {
                    char nuevaLetra = (char)(letra + clave);

                    if (nuevaLetra > 'Z')
                    {
                        nuevaLetra = (char)(nuevaLetra - 26); // Asegurar que permanezca en el rango de letras mayúsculas
                    }

                    textoCifrado += nuevaLetra;
                }
                else
                {
                    textoCifrado += letra; // Mantener caracteres no alfabéticos sin cambios
                }
            }

            return textoCifrado;
        }

        public string descifrar()
        {
            textoCifrado = ""; // Inicializar la cadena de texto descifrado

            // Normaliza el texto antes de descifrar
            textoSinCifrar = RemoveAccentedCharacters(textoSinCifrar);
            textoSinCifrar = textoSinCifrar.ToUpper(); // Convierte todo el texto a mayúsculas
            textoSinCifrar = new string(textoSinCifrar.Where(char.IsLetter).ToArray()); // Elimina caracteres no alfabéticos

            foreach (char letra in textoSinCifrar)
            {
                if (char.IsLetter(letra)) // Solo descifrar letras
                {
                    char nuevaLetra = (char)(letra - clave);

                    if (nuevaLetra < 'A')
                    {
                        nuevaLetra = (char)(nuevaLetra + 26); // Asegurar que permanezca en el rango de letras mayúsculas
                    }

                    textoCifrado += nuevaLetra;
                }
                else
                {
                    textoCifrado += letra; // Mantener caracteres no alfabéticos sin cambios
                }
            }

            return textoCifrado;
        }
    }
}
