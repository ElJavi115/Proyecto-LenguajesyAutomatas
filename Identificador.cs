using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorCeceña
{
    public class Identificador : Token
    {
        public string TipoDato { get; set; }
        public string Contexto { get; set; }

        public Identificador(string valor, int linea, int columna, string tipoDato, string contexto) : base(valor, "IDENTIFICADOR", linea, columna)
        {
            TipoDato = tipoDato;
            Contexto = contexto;
        }
    }

}
