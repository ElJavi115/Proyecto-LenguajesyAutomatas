using CompiladorCeceña;
using System;
using System.Collections.Generic;

public class AnalizadorSintactico
{
    private List<Token> tokens;
    private int index;
    private string erroresSintacticos, tablaSimbolos;
    private List<Identificador> identificadores;
    private bool estaEnMetodo;

    public void Analizar(List<Token> tokens, List<Identificador> identificadores)
    {
        this.tokens = tokens;
        this.index = 0;
        this.erroresSintacticos = "";
        this.identificadores = identificadores;
        estaEnMetodo = false;
        Programa();
    }

    private void Programa()
    {
        index += Match("clase");
        index += Identificador();
        index += Match("{");
        while (index < tokens.Count - 1)
        {
            if (tokens[index].Valor.Equals("funcion"))
            {
                Funcion();
            }
            else if (tokens[index].Tipo.Equals("Tipo de dato"))
            {
                Declaracion();
            }
            else
            {
                Sentencia();
            }
        }
    }

    private void Declaracion()
    {
        index += Tipo();
        foreach (Identificador identificador in identificadores)
        {
            if (identificador.Valor.Equals(tokens[index].Valor))
            {
                identificador.Contexto = estaEnMetodo ? "Variable de Metodo" : "Variable de Clase";
            }
        }
        index += Identificador();
        index += Match(";");
    }

    private void Funcion()
    {
        if (Match("funcion") == 1)
        {
            index++;
            estaEnMetodo = true;
        }
        index += Identificador();
        index += Match("(");
        Parametros();
        index += Match(")");
        index += Tipo();
        Bloque();
    }

    private int Tipo()
    {
        if (index >= tokens.Count || !tokens[index].Tipo.Equals("Tipo de dato"))
        {
            ErrorSintactico("Se esperaba un tipo de dato");
            return 0;
        }
        return 1;
    }

    private int Identificador()
    {
        if (index >= tokens.Count || !tokens[index].Tipo.Equals("Identificador"))
        {
            ErrorSintactico("Se esperaba un identificador");
            return 0;
        }
        return 1;
    }

    private void Parametros()
    {
        if (index < tokens.Count && !tokens[index].Valor.Equals(")"))
        {
            index += Tipo();
            index += Identificador();
            ParametrosResto();
        }
    }

    private void ParametrosResto()
    {
        if (index < tokens.Count && tokens[index].Valor.Equals(","))
        {
            index += Match(",");
            index += Tipo();
            index += Identificador();
            ParametrosResto();
        }
    }

    private void Bloque()
    {
        index += Match("{");
        while (index < tokens.Count && tokens[index].Tipo.Equals("Tipo de dato"))
        {
            Declaracion();
        }
        while (index < tokens.Count && !tokens[index].Valor.Equals("}"))
        {
            Sentencia();
        }
        if (Match("}") == 1)
        {
            index++;
            estaEnMetodo = false;
        }
    }

    private void Sentencia()
    {
        if (index >= tokens.Count)
        {
            return;
        }
        if (tokens[index].Tipo.Equals("Palabra reservada"))
        {
            string palabraReservada = tokens[index].Valor;
            if (palabraReservada.Equals("si"))
            {
                Condicional();
            }
            else if (palabraReservada.Equals("para"))
            {
                CicloFor();
            }
            else if (palabraReservada.Equals("mientras"))
            {
                CicloWhile();
            }
            else if (palabraReservada.Equals("retorna"))
            {
                Match("retorna");
                if (tokens[index].Tipo.Equals("Identificador"))
                {
                    Identificador();
                    Match(";");
                }
                else
                {
                    Expresion();
                    Match(";");
                }
            }
            else
            {
                Declaracion();
            }
        }
        else if (tokens[index].Tipo.Equals("Identificador"))
        {
            Asignacion();
        }
        else
        {
            ErrorSintactico(tokens[index].Valor + " no es una sentencia válida");
            index++;
        }
    }

    private void Condicional()
    {
        index += Match("si");
        index += Match("(");
        Expresion();
        index += Match(")");
        Bloque();
    }

    private void CicloFor()
    {
        index += Match("para");
        index += Match("(");
        Declaracion();
        Expresion();
        index += Match(";");
        Asignacion();
        index += Match(")");
        Bloque();
    }

    private void CicloWhile()
    {
        index += Match("mientras");
        index += Match("(");
        Expresion();
        index += Match(")");
        Bloque();
    }

    private void Asignacion()
    {
        index += Identificador();
        index += Match("=");
        Expresion();
        index += Match(";");
    }

    private void Expresion()
    {
        Termino();
        ExpresionResto();
    }

    private void ExpresionResto()
    {
        if (index < tokens.Count && (tokens[index].Valor.Equals("+") ||
                tokens[index].Valor.Equals("-") || tokens[index].Valor.Equals("<") ||
                tokens[index].Valor.Equals(">") || tokens[index].Valor.Equals("==")))
        {
            index += Match(tokens[index].Valor);
            Termino();
            ExpresionResto();
        }
    }

    private void Termino()
    {
        Factor();
        TerminoResto();
    }

    private void TerminoResto()
    {
        if (index < tokens.Count && tokens[index].Valor.Equals("*"))
        {
            index += Match("*");
            Factor();
            TerminoResto();
        }
    }

    private void Factor()
    {
        if (index < tokens.Count && tokens[index].Valor.Equals("("))
        {
            index += Match("(");
            Expresion();
            index += Match(")");
        }
        else
        {
            if (index >= tokens.Count)
            {
                return;
            }
            if (!tokens[index].Tipo.Equals("Identificador") &&
                    !tokens[index].Tipo.Equals("Numero"))
            {
                ErrorSintactico("Se esperaba un identificador o número");
            }
            index++;
        }
    }

    private int Match(string expectedToken)
    {
        if (index >= tokens.Count)
        {
            return 0;
        }
        if (!tokens[index].Valor.Equals(expectedToken))
        {
            if (tokens[index].Valor.Equals(";"))
            {
                Console.WriteLine("entro al error match");
            }
            ErrorSintactico(
                    "Se esperaba '" + expectedToken + "' pero se encontro '" + tokens[index].Valor + "'");
            return 0;
        }
        return 1;
    }

    private void ErrorSintactico(string mensaje)
    {
        if (index >= tokens.Count)
        {
            return;
        }
        int linea = tokens[index].Linea;
        int columna = tokens[index].Columna;
        // Console.WriteLine(mensaje + " en la linea " + linea + ", columna " +
        // columna);
        erroresSintacticos += mensaje + " en la linea " + linea + ", columna " + columna + "\n";
        index++;
    }

    public string GetErroresSintacticos()
    {
        return erroresSintacticos;
    }

    public string GetTablaSimbolos()
    {
        tablaSimbolos = "";
        foreach (Identificador identificador in identificadores)
        {
            tablaSimbolos += identificador.Valor + " -> " + identificador.TipoDato;
            if (!string.IsNullOrEmpty(identificador.Contexto))
            {
                tablaSimbolos += " -> " + identificador.Contexto;
            }
            tablaSimbolos += "\n";
        }
        return tablaSimbolos;
    }
}