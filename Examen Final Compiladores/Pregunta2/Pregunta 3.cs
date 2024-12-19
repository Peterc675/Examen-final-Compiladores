using System;
using System.Text.RegularExpressions;

class GrammarValidator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cadena para validar:");
        string input = Console.ReadLine();

        // Expresión regular basada en la gramática de la pregunta 3
        string fileGrammar = @"^(\/(home|var|dir))+\/[a-zA-Z0-9_]+\.(txt|docx|ext)$";

        if (Regex.IsMatch(input, fileGrammar))
        {
            Console.WriteLine("La cadena es válida según la gramática.");
        }
        else
        {
            Console.WriteLine("La cadena no es válida según la gramática.");
        }
    }
}
