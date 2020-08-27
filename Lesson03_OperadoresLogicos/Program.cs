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

            WriteLine( 7 > 6 && 5 ==5); // Respuesta: TRUE, las dos son verdaderas
            WriteLine( 2 > 5 && 4 > 3); // Respuesta: FALSE,  una verdad y otro false
            WriteLine( 5 > 2 && 3 > 4); // Respuesta: FALSE: una verdady otro falso
            WriteLine( 2 > 5 && 5 != 5); //Respuesta FALSE: Los dos son 



            //Para mantener activa la consola...
            WriteLine("\nEnter Close");
            _ = ReadLine();
            
        }
    }
}
