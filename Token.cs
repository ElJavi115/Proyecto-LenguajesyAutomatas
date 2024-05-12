using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorCeceña
{
    public class Token
    {
        public string Valor { get; set; }
        public string Tipo { get; set; }
        public int Linea { get; set; }
        public int Columna { get; set; }

        public Token(string valor, string tipo, int linea, int columna)
        {
            this.Valor = valor;
            this.Tipo = tipo;
            this.Linea = linea;
            this.Columna = columna;
        }

        
    }
}
