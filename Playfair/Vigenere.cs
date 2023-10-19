using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playfair
{
    public class Vigenere
    {
        string[] ArregloColum = new string[27];
        string[] ArregloFil = new string[27];

        public void IniciarValiables()
        {
            ArregloColum[0] = "AColum";
            ArregloColum[1] = "BColum";
            ArregloColum[2] = "CColum";
            ArregloColum[3] = "DColum";
            ArregloColum[4] = "EColum";   
            ArregloColum[5] = "FColum";
            ArregloColum[6] = "GColum";
            ArregloColum[7] = "HColum";
            ArregloColum[8] = "IColum";
            ArregloColum[9] = "JColum";
            ArregloColum[10] = "KColum";
            ArregloColum[11] = "LColum";
            ArregloColum[12] = "MColum";
            ArregloColum[13] = "NColum";
            ArregloColum[14] = "ÑColum";
            ArregloColum[15] = "OColum";
            ArregloColum[16] = "PColum";
            ArregloColum[17] = "QColum";
            ArregloColum[18] = "RColum";
            ArregloColum[19] = "SColum";
            ArregloColum[20] = "TColum";
            ArregloColum[21] = "UColum";
            ArregloColum[22] = "VColum";
            ArregloColum[23] = "WColum";
            ArregloColum[24] = "XColum";
            ArregloColum[25] = "YColum";
            ArregloColum[26] = "ZColum";



            ArregloFil[0] = "AFiL";
            ArregloFil[1] = "BFiL";
            ArregloFil[2] = "CFiL";
            ArregloFil[3] = "DFiL";
            ArregloFil[4] = "EFiL";
            ArregloFil[5] = "FFiL";
            ArregloFil[6] = "GFiL";
            ArregloFil[7] = "HFiL";
            ArregloFil[8] = "IFiL";
            ArregloFil[9] = "JFiL";
            ArregloFil[10] = "KFiL";
            ArregloFil[11] = "LFiL";
            ArregloFil[12] = "MFiL";
            ArregloFil[13] = "NFiL";
            ArregloFil[14] = "ÑFiL";
            ArregloFil[15] = "OFiL";
            ArregloFil[16] = "PFiL";
            ArregloFil[17] = "QFiL";
            ArregloFil[18] = "RFiL";
            ArregloFil[19] = "SFiL";
            ArregloFil[20] = "TFiL";
            ArregloFil[21] = "UFiL";
            ArregloFil[22] = "VFiL";
            ArregloFil[23] = "WFiL";
            ArregloFil[24] = "XFiL";
            ArregloFil[25] = "YFiL";
            ArregloFil[26] = "ZFiL";

        }

        public int RecuperarIndices(string parametro)
        {
            int Resultado = -1;

            if (parametro.Contains("Fil"))
            {
                for (int i = 0; i <= ArregloFil.Length - 1; i++)
                {
                    if (parametro == ArregloFil[i])
                    {
                        Resultado = i;
                        break;
                    }
                }

            }
            else if (parametro.Contains("Colum"))
            {
                for (int i = 0; i <= ArregloColum.Length - 1; i++)
                {
                    if (parametro == ArregloColum[i])
                    {
                        Resultado = i;
                        break;
                    }
                }  

            }

            return Resultado;
        }




    }
}
