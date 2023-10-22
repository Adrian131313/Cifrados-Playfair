using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrados_Seguridad
{
    public class clasePadre
    {
        protected string textoSinCifrar;
        protected string clave;
        protected string textoCifrado;

        public clasePadre(string textoSinCifrar, string clave)
        {
            this.textoSinCifrar = textoSinCifrar;
            this.clave = clave;
            

        }
        public clasePadre(string textoSinCifrar) 
        {
            this.textoSinCifrar = textoSinCifrar;
        }

       

    }

}
