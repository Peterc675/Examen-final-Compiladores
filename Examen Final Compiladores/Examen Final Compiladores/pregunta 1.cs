using System;

class Automata
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena (use los caracteres: m, h, a):");
        string input = Console.ReadLine();

        string estadoActual = "q0";

        foreach (char c in input)
        {
            switch (estadoActual)
            {
                case "q0":
                    if (c == 'm') estadoActual = "q1";
                    else estadoActual = "q0"; 
                    break;

                case "q1":
                    if (c == 'h') estadoActual = "q3";
                    else if (c == 'm') estadoActual = "q2";
                    else if (c == 'a') estadoActual = "q3";
                    else estadoActual = "q0"; 
                    break;

                case "q2":
                    if (c == 'h') estadoActual = "q2";
                    else estadoActual = "q0"; 
                    break;

                case "q3":
                    if (c == 'a') estadoActual = "q3";
                    else estadoActual = "q0"; 
                    break;

                default:
                    estadoActual = "q0";
                    break;
            }
        }

        if (estadoActual == "q3")
        {
            Console.WriteLine("Cadena aceptada.");
        }
        else
        {
            Console.WriteLine("Cadena no aceptada.");
        }
    }
}
