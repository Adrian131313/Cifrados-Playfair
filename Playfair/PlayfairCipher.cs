using Cifrados_Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PlayfairCipher : clasePadre
{
    private char[,] playfairMatrix;

    public PlayfairCipher(string textoSinCifrar, string clave, string textoCifrado) : base(textoSinCifrar, clave, textoCifrado)
    {
        GeneratePlayfairMatrix(clave);
    }


    

    public string Encrypt()
    {
        StringBuilder encryptedText = new StringBuilder();
        textoSinCifrar = NormalizeText(textoSinCifrar); // Elimina caracteres no válidos y convierte a mayúsculas


        for (int i = 0; i < textoSinCifrar.Length; i += 2)
        {
            char firstChar = textoSinCifrar[i];
            char secondChar = (i + 1 < textoSinCifrar.Length) ? textoSinCifrar[i + 1] : 'X';

            // Encuentra las posiciones de los caracteres en la matriz Playfair
            int[] firstPosition = GetMatrixPosition(firstChar);
            int[] secondPosition = GetMatrixPosition(secondChar);

            if (firstPosition[0] == secondPosition[0]) // Misma fila
            {
                encryptedText.Append(playfairMatrix[firstPosition[0], (firstPosition[1] + 1) % 5]);
                encryptedText.Append(playfairMatrix[secondPosition[0], (secondPosition[1] + 1) % 5]);
            }
            else if (firstPosition[1] == secondPosition[1]) // Misma columna
            {
                encryptedText.Append(playfairMatrix[(firstPosition[0] + 1) % 5, firstPosition[1]]);
                encryptedText.Append(playfairMatrix[(secondPosition[0] + 1) % 5, secondPosition[1]]);
            }
            else // Forma un rectángulo
            {
                encryptedText.Append(playfairMatrix[firstPosition[0], secondPosition[1]]);
                encryptedText.Append(playfairMatrix[secondPosition[0], firstPosition[1]]);
            }
        }

        return encryptedText.ToString();
    }


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




    private string NormalizeText(string text)
    {
        if (text != null)
        {
            text = text.ToUpper(); // Convierte todo el texto a mayúsculas
            text = text.Replace('Ñ', 'N'); // Reemplaza 'Ñ' por 'N'
            text = new string(text.Where(char.IsLetter).ToArray()); // Elimina caracteres no alfabéticos

            // Agrega una 'X' entre letras repetidas
            for (int i = 0; i < text.Length - 1; i += 2)
            {
                if (text[i] == text[i + 1])
                {
                    text = text.Insert(i + 1, "X");
                }
            }

            // Asegúrate de que la longitud del texto sea par (agrega un carácter 'X' si es necesario)
            if (text.Length % 2 != 0)
            {
                text += 'X';
            }
        }
        return text;
    }


    private int[] GetMatrixPosition(char letter)
    {
        if (letter == 'J')
            letter = 'I'; // Tratar 'J' como 'I'

        int[] position = new int[2];
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (playfairMatrix[row, col] == letter)
                {
                    position[0] = row;
                    position[1] = col;
                    return position;
                }
            }
        }
        return position; // Si no se encuentra la letra, se devuelve [0, 0] como valor predeterminado.
    }

    private void GeneratePlayfairMatrix(string key)
    {
        // Crear una matriz de 5x5 para Playfair
        playfairMatrix = new char[5, 5];
        bool[] usedLetters = new bool[26]; // Para rastrear las letras utilizadas

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
                        if (keyIndex >= key.Length)
                            break;
                        currentChar = key[keyIndex];
                    }
                    playfairMatrix[row, col] = currentChar;
                    usedLetters[currentChar - 'A'] = true;
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

    public string GetPlayfairMatrixAsString()
    {
        StringBuilder matrixString = new StringBuilder();
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                matrixString.Append(playfairMatrix[row, col] + " ");
            }
            matrixString.AppendLine();
        }
        return matrixString.ToString();
    }


}
