using Cifrados_Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PlayfairCipher : clasePadre
{
    private char[,] playfairMatrix; // Matriz utilizada en el cifrado Playfair

    // Constructor de la clase, heredado de la clase base "clasePadre"
    public PlayfairCipher(string textoSinCifrar, string clave, string textoCifrado) : base(textoSinCifrar, clave, textoCifrado)
    {
        // Genera la matriz Playfair utilizando la clave proporcionada
        GeneratePlayfairMatrix(clave);
    }

    //Se utiliza para cifrar un texto sin cifrar utilizando el cifrado Playfair.**************************************
    public string Encrypt()
    {
        // StringBuilder para almacenar el texto cifrado
        StringBuilder encryptedText = new StringBuilder();

        // Normaliza el texto sin cifrar eliminando caracteres no válidos y convirtiéndolo a mayúsculas
        textoSinCifrar = NormalizeText(textoSinCifrar);

        // Recorre el texto sin cifrar de dos en dos caracteres
        for (int i = 0; i < textoSinCifrar.Length; i += 2)
        {
            char firstChar = textoSinCifrar[i];
            char secondChar = (i + 1 < textoSinCifrar.Length) ? textoSinCifrar[i + 1] : 'X';

            // Encuentra las posiciones de los caracteres en la matriz Playfair
            int[] firstPosition = GetMatrixPosition(firstChar);
            int[] secondPosition = GetMatrixPosition(secondChar);

            // Verifica si los caracteres están en la misma fila en la matriz Playfair
            if (firstPosition[0] == secondPosition[0]) // Misma fila
            {
                // Si están en la misma fila, reemplaza cada caracter por el siguiente en la misma fila
                encryptedText.Append(playfairMatrix[firstPosition[0], (firstPosition[1] + 1) % 5]);
                encryptedText.Append(playfairMatrix[secondPosition[0], (secondPosition[1] + 1) % 5]);
            }
            // Verifica si los caracteres están en la misma columna en la matriz Playfair
            else if (firstPosition[1] == secondPosition[1]) // Misma columna
            {
                // Si están en la misma columna, reemplaza cada caracter por el siguiente en la misma columna
                encryptedText.Append(playfairMatrix[(firstPosition[0] + 1) % 5, firstPosition[1]]);
                encryptedText.Append(playfairMatrix[(secondPosition[0] + 1) % 5, secondPosition[1]]);
            }
            else // Forma un rectángulo
            {
                // Si no están en la misma fila ni columna, forman un rectángulo
                // Reemplaza cada caracter por el caracter en la esquina opuesta del rectángulo
                encryptedText.Append(playfairMatrix[firstPosition[0], secondPosition[1]]);
                encryptedText.Append(playfairMatrix[secondPosition[0], firstPosition[1]]);
            }
        }
        // Devuelve el texto cifrado como una cadena
        return encryptedText.ToString();
    }

    //Se utiliza para descifrar un texto cifrado con el cifrado Playfair.**********************
    public string Decrypt()
    {
        // Inicializa un objeto StringBuilder para almacenar el texto descifrado
        StringBuilder decryptedText = new StringBuilder();

        // Normaliza el texto cifrado: elimina caracteres no válidos y lo convierte a mayúsculas
        textoCifrado = NormalizeText(textoCifrado);

        // Itera a través del texto cifrado de dos caracteres en dos caracteres
        if (textoCifrado != null)
        {
            for (int i = 0; i < textoCifrado.Length; i += 2)
            {
                char firstChar = textoCifrado[i];
                char secondChar = textoCifrado[i + 1];

                // Obtiene las posiciones de los dos caracteres en la matriz Playfair
                int[] firstPosition = GetMatrixPosition(firstChar);
                int[] secondPosition = GetMatrixPosition(secondChar);

                if (firstPosition[0] == secondPosition[0]) // Misma fila
                {
                    // Agrega los caracteres descifrados a la cadena
                    decryptedText.Append(playfairMatrix[firstPosition[0], (firstPosition[1] + 4) % 5]);
                    decryptedText.Append(playfairMatrix[secondPosition[0], (secondPosition[1] + 4) % 5]);
                }
                else if (firstPosition[1] == secondPosition[1]) // Misma columna
                {
                    // Agrega los caracteres descifrados a la cadena
                    decryptedText.Append(playfairMatrix[(firstPosition[0] + 4) % 5, firstPosition[1]]);
                    decryptedText.Append(playfairMatrix[(secondPosition[0] + 4) % 5, secondPosition[1]]);
                }
                else // Forma un rectángulo
                {
                    // Agrega los caracteres descifrados a la cadena
                    decryptedText.Append(playfairMatrix[firstPosition[0], secondPosition[1]]);
                    decryptedText.Append(playfairMatrix[secondPosition[0], firstPosition[1]]);
                }
            }
        }
        // Devuelve el texto descifrado como una cadena
        return decryptedText.ToString();
    }

    private string RemoveAccentedCharacters(string text)
    {
        // Define los pares de reemplazo para letras acentuadas
        var replacements = new Dictionary<char, char>
    {
        {'Á', 'A'},
        {'É', 'E'},
        {'Í', 'I'},
        {'Ó', 'O'},
        {'Ú', 'U'},
        {'Ü', 'U'},
        // Agrega más pares según sea necesario
    };

        // Realiza el reemplazo de las letras acentuadas
        foreach (var replacement in replacements)
        {
            text = text.Replace(replacement.Key, replacement.Value);
        }

        return text;
    }

    //Prepara y normaliza el texto antes de cifrarlo con el cifrado Playfair************************
    private string NormalizeText(string text)
    {
        // Verifica si el texto de entrada no es nulo
        if (text != null)
        {
            text = text.ToUpper(); // Convierte todo el texto a mayúsculas
            text = RemoveAccentedCharacters(text);// Realiza la conversión de letras acentuadas
            text = text.Replace('Ñ', 'N'); // Reemplaza 'Ñ' por 'N' para tratar ambas letras de la misma manera
            text = new string(text.Where(char.IsLetter).ToArray()); // Elimina caracteres no alfabéticos

            // Agrega una 'X' entre letras repetidas consecutivas
            for (int i = 0; i < text.Length - 1; i += 2)
            {
                // Comprueba si dos caracteres consecutivos son iguales
                if (text[i] == text[i + 1])
                {
                    // Inserta una 'X' entre ellos para evitar problemas con el cifrado Playfair
                    text = text.Insert(i + 1, "X");
                }
            }

            // Asegúrate de que la longitud del texto sea par (agrega un carácter 'X' si es necesario)
            if (text.Length % 2 != 0)
            {
                // Agrega un carácter 'X' al final del texto si es necesario
                text += 'X';
            }
        }
        // Devuelve el texto normalizado
        return text;
    }

    //Determina la posición de una letra en la matriz Playfair*************************************
    private int[] GetMatrixPosition(char letter)
    {
        // Si la letra es 'J', trátala como 'I' para asegurar coherencia en el cifrado
        if (letter == 'J')
            letter = 'I';

        // Crea un arreglo de dos elementos para almacenar la posición [fila, columna]
        int[] position = new int[2];

        // Itera a través de las filas y columnas de la matriz Playfair (5x5)
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                // Compara cada elemento de la matriz Playfair con la letra proporcionada
                if (playfairMatrix[row, col] == letter)
                {
                    // Si se encuentra la letra, almacena su posición [fila, columna] en el arreglo 'position'
                    position[0] = row; // La fila donde se encuentra la letra
                    position[1] = col; // La columna donde se encuentra la letra

                    // Devuelve la posición y sale de la función
                    return position;
                }
            }
        }
        // Si no se encuentra la letra en la matriz Playfair, se devuelve [0, 0] como valor predeterminado.
        return position;
    }


    // Método privado para generar la matriz Playfair basada en la clave******************************
    private void GeneratePlayfairMatrix(string key)
    {
        // Crear una matriz de 5x5 para Playfair
        playfairMatrix = new char[5, 5];

        // Un arreglo para rastrear las letras utilizadas en la clave
        bool[] usedLetters = new bool[26];

        // Elimina caracteres duplicados y convierte la clave a mayúsculas
        key = new string(key.Distinct().Where(char.IsLetter).ToArray()).ToUpper();

        // Llena la matriz con la clave
        int keyIndex = 0;
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (keyIndex < key.Length)
                {
                    char currentChar = key[keyIndex];

                    // Evita repetir letras en la matriz
                    while (usedLetters[currentChar - 'A'])
                    {
                        keyIndex++;

                        // Verifica si se ha agotado la clave
                        if (keyIndex >= key.Length)
                            break;
                        currentChar = key[keyIndex];
                    }

                    // Asigna la letra actual a la posición de la matriz
                    playfairMatrix[row, col] = currentChar;

                    // Marca la letra actual como utilizada
                    usedLetters[currentChar - 'A'] = true;

                    // Avanza al siguiente carácter de la clave
                    keyIndex++;
                }
                else
                {
                    // Rellena la matriz con letras del alfabeto que no se encuentren en la clave
                    for (char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        if (letter != 'J' && !usedLetters[letter - 'A'])
                        {
                            playfairMatrix[row, col] = letter;
                            usedLetters[letter - 'A'] = true;
                            break;
                        }
                    }
                }
            }
        }
    }

    //Sirve para visualizar la matriz Playfair en cadena de texto 
    public string GetPlayfairMatrixAsString()
    {
        // StringBuilder para almacenar la representación de la matriz Playfair como cadena
        StringBuilder matrixString = new StringBuilder();
        // Itera a través de las filas y columnas de la matriz Playfair
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                // Agrega cada carácter de la matriz seguido de un espacio en blanco
                matrixString.Append(playfairMatrix[row, col] + " ");
            }

            // Agrega un salto de línea al final de cada fila
            matrixString.AppendLine();
        }

        // Devuelve la representación de la matriz Playfair como una cadena
        return matrixString.ToString();
    }
}
