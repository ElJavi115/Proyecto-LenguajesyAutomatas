using CompiladorCeceña;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class AnalizadorLexico
{
    private string errores, tablaSimbolos;
    private string[] lineas;
    private List<Token> tokens;
    private List<Identificador> identificadores;
    private static HashSet<KeyValuePair<string, string>> setIdentificadores;
    private string[] tokensLinea;

    public string Analizar(string codigo)
    {
        lineas = codigo.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        tokens = new List<Token>();
        errores = "";
        tablaSimbolos = "";
        int linea = 0;
        string tipoAnterior = "";
        setIdentificadores = new HashSet<KeyValuePair<string, string>>();
        identificadores = new List<Identificador>();

        foreach (string lineaCodigo in lineas)
        {
            Console.WriteLine(lineaCodigo);
            linea++;
            int columna = 1;
            tokensLinea = Regex.Split(lineaCodigo.Trim(), "\\s+|(?=[{}()\\[\\]=;,.])|(?<=[{}()\\[\\]=;,])");
            foreach (string token in tokensLinea)
            {
                if (token.Equals(""))
                {
                    columna++;
                    continue;
                }
                string tipo = GetTipo(token);
                if (tipo.Equals("Palabra reservada") || tipo.Equals("Tipo de dato"))
                {
                    tipoAnterior = token;
                }
                if (tipo.Equals("Identificador") &&
                        !tipoAnterior.Equals("si") &&
                        !tipoAnterior.Equals("sino") &&
                        !tipoAnterior.Equals("mientras"))
                {

                    if (tipoAnterior.Equals("clase"))
                    {
                        tipoAnterior = "Nombre de Clase";
                    }
                    if (tipoAnterior.Equals("funcion"))
                    {
                        tipoAnterior = "Nombre de Metodo";
                    }
                    if (tipoAnterior.Equals("entero"))
                    {
                        tipoAnterior = "Variable Entera";
                    }
                    if (tipoAnterior.Equals("flotante"))
                    {
                        tipoAnterior = "Variable Flotante";
                    }
                    if (tipoAnterior.Equals("booleano"))
                    {
                        tipoAnterior = "Variable Booleana";
                    }
                    if (tipoAnterior.Equals("string"))
                    {
                        tipoAnterior = "Variable Cadena";
                    }

                    bool existe = false;
                    foreach (KeyValuePair<string, string> entrada in setIdentificadores)
                    {
                        if (token.Equals(entrada.Key))
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (!existe)
                    {
                        KeyValuePair<string, string> aux = new KeyValuePair<string, string>(token, tipoAnterior);
                        setIdentificadores.Add(aux);
                        identificadores.Add(new Identificador(token, linea, columna, tipoAnterior, ""));
                        tablaSimbolos += (token + " ->" + tipoAnterior + "\n");
                    }
                }
                sb.Append(token);
                sb.Append(" -> ");
                sb.Append(tipo);
                sb.Append("\n");
                if (tipo.Equals("Error"))
                {
                    errores += "Error en la linea " + linea + " columna " + columna + ": " + token + "\n";
                }
                columna++;
                tokens.Add(new Token(token, tipo, linea, columna));
            }
        }
        return sb.ToString();
    }

    public string GetErrores()
    {
        return errores;
    }

    public string GetTablaSimbolos()
    {
        return tablaSimbolos;
    }

    private static string GetTipo(string token)
    {
        if (Regex.IsMatch(token, "clase|funcion|si|sino|mientras|retorna|para"))
        {
            return "Palabra reservada";
        }
        if (Regex.IsMatch(token, "entero|flotante|booleano|string"))
        {
            return "Tipo de dato";
        }
        if (Regex.IsMatch(token, "[a-zA-Z][a-zA-Z0-9]*"))
        {
            return "Identificador";
        }
        if (Regex.IsMatch(token, "\".*?\""))
        {
            return "Cadena";
        }
        if (Regex.IsMatch(token, "0|[1-9][0-9]{0,2}|1000"))
        {
            return "Numero";
        }
        if (Regex.IsMatch(token, "[{}()\\[\\]=;,.]"))
        {
            return "Simbolo";
        }
        if (Regex.IsMatch(token, "\\+|-|\\*|/|==|<|>|<=|>="))
        {
            return "Operador Binario";
        }
        if (Regex.IsMatch(token, "=|;"))
        {
            return "Operador";
        }
        return "Error";
    }

    public List<Token> GetTokens()
    {
        return tokens;
    }

    public List<Identificador> GetIdentificadores()
    {
        return this.identificadores;
    }
}