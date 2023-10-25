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

        public string cifrar()
        {
            textoCifrado = ""; // Inicializar la cadena de texto cifrado

            foreach (char letra in textoSinCifrar)
            {
                if (char.IsLetter(letra)) // Solo cifrar letras
                {
                    char nuevaLetra = (char)(letra + clave);

                    if (char.IsUpper(letra) && nuevaLetra > 'Z')
                    {
                        nuevaLetra = (char)(nuevaLetra - 26); // Asegurar que permanezca en el rango de letras mayúsculas
                    }
                    else if (char.IsLower(letra) && nuevaLetra > 'z')
                    {
                        nuevaLetra = (char)(nuevaLetra - 26); // Asegurar que permanezca en el rango de letras minúsculas
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

            foreach (char letra in textoSinCifrar)
            {
                if (char.IsLetter(letra)) // Solo descifrar letras
                {
                    char nuevaLetra = (char)(letra - clave);

                    if (char.IsUpper(letra) && nuevaLetra < 'A')
                    {
                        nuevaLetra = (char)(nuevaLetra + 26); // Asegurar que permanezca en el rango de letras mayúsculas
                    }
                    else if (char.IsLower(letra) && nuevaLetra < 'a')
                    {
                        nuevaLetra = (char)(nuevaLetra + 26); // Asegurar que permanezca en el rango de letras minúsculas
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
