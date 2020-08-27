using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;



namespace Lesson03_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "OPERADORES LOGICOS";

            //1. UTILIZANDO EL OPERADOR AND (&&)
            //Sirve para hacer doble validacion y que las dos se cumplan si o si
            WriteLine("\nOPERADOR AND ");

            WriteLine(7 > 6 && 5 == 5); // Respuesta: TRUE, las dos son verdaderas
            WriteLine(2 > 5 && 4 > 3); // Respuesta: FALSE,  una verdad y otro false
            WriteLine(5 > 2 && 3 > 4); // Respuesta: FALSE: una verdady otro falso
            WriteLine(2 > 5 && 5 != 5); //Respuesta FALSE: Los dos son 
            WriteLine();

            WriteLine("AND DENTRO DE IF ");

            //Usando dentro de if
            if (ReadLine() == "Cafe" && ReadLine() == "Leche") // Si se escribe las mismas palabras es true
                WriteLine("Cafe con Leche");
            else
                WriteLine("Cafe sin Leche");

            WriteLine("\nOPERADOR AND Y BREAK ");

            //Usando BREAK en CICLOS

            while (true)
            {
                //Clear();

                bool firstConverted = double.TryParse(ReadLine(), out double v1);
                bool secondConverted = double.TryParse(ReadLine(), out double v2);

                if (firstConverted && secondConverted)
                    WriteLine($"{v1} / {v2}= {v1 / v2}");

                ConsoleKey k = ReadKey(true).Key;
                if (k == ConsoleKey.Enter)
                    break;
            }

            WriteLine("\nOPERADOR OR || ");

            //USANDO EL OPERADOR OR --> || 

            string cadena = ReadLine();
            string cadenaFormatada = "";
            int conteoVocales = 0;

            foreach (char del in cadena) // Hola desde Peru -> HoladesdePeru
                if (del != ' ')
                    cadenaFormatada += del;
                
            foreach (char v in cadenaFormatada)
                //search a,e,i,o,u
                if (v == 'a' || v == 'e'  || v == 'i' || v == 'o' || v == 'u')
                    conteoVocales++;

            WriteLine($"Count vocal: {conteoVocales} ");
            WriteLine($"Other letter: {cadenaFormatada.Length - conteoVocales}");

            //Para mantener activa la consola...
            WriteLine("\nEnter Close");
            _ = ReadKey();
            
        }
    }
}
