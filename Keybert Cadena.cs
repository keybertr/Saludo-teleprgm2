using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Escriba una frase: ");
            
            String cadena = Console.ReadLine();
            String[] palabras = cadena.Split();
            for (int i = 0; i < palabras.Length; i++)  
            {
                Console.WriteLine(palabras[i]);

            }    
        }
    }
}