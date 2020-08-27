using System;
using static System.Console; // Permite ya no escribir Console.Writeline si no solo WriteLine();

namespace Lesson02_ControlFlujo
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "CONTROL DE FLUJO"; // Metodo que permite poner titulo consola

            // 1. Aprendiendo Logica de condiciones <, > , >=, <= , ==, !=
            // da como respuesta un boleano
            WriteLine("COMPARADORES");

            WriteLine($"{4} =  {5}? : {4 == 5}"); // Comparas si 4 = 5 -> No o false
            WriteLine($"{4} <  {5}? : {4 <  5}"); //  4  es menor que 5 -> yes or true
            WriteLine($"{4} <= {5}? : {4 <= 5}");  //4  es menor o igual que 5 -> yes or true
            WriteLine($"{4} <= {4}? : {4 <= 4}");  //4  es menor o igual que 4 -> yes or true
            WriteLine($"{4} >  {5}? : {4 >  5}");  //4  es meyor 5 -> not or false
            WriteLine($"{5} >= {5}? : {5 >= 5}");  //5  es meyor o igual 5 -> yes or true
            WriteLine($"{4} != {5}? : {4 != 5} \n");  //4  es diferente 5 -> yes or true


            // 2. Aprendiendo If and Else para hacer una 
            //determinada accion

            WriteLine("'IF' AND 'ELSE' ");

            decimal precioone = 500M;
            decimal preciotwo = 100M;

            //Utilizando If and else

            if (precioone > preciotwo) //precioone es mayor  preciotwo si es true se ejecuta la sentencia
                WriteLine($"EL precio {precioone:C} es mayor {preciotwo:C}");
            else
                WriteLine($"EL precio {precioone:C} es menor {preciotwo:C}");

            if (precioone < preciotwo) //precioone es mayor  preciotwo si es true se ejecuta la sentencia
                WriteLine($"EL precio {precioone:C} es menor {preciotwo:C}");
            else
                WriteLine($"EL precio {precioone:C} es mayor {preciotwo:C}");

            // USANDO TRYPARSE PARA SER MAS LEGIBLE EN EL CODIGO

            WriteLine("\n USANDO TRYPARSE");

            WriteLine("Ingrese un valor:");
            string valor = ReadLine();
            if (double.TryParse(valor, out double value))
                WriteLine($"{value} * 0.50 ={value * 0.50}");
            else
                WriteLine($"{valor} * 0.50= No es factible..");


            // USANDO OPERADORES ++ ; -- ; =+ ; =- 
            WriteLine("\n USANDO OPERADORES INCREMENTO Y DECREMENTO");

            int numero = 1;

            // Da el mismo resultado ya que ++ incrementa en 1
            WriteLine($" {numero} + 1  : {numero + 1}"); // 2
            WriteLine($" ++numero     : { ++numero }");   //  2

            // Da el mismo resultado ya que -- decrementa en 1
            WriteLine($" {numero} - 1  : {numero - 1}"); // 2
            WriteLine($" --numero     : { --numero }");   //  2

            // Tiene la misma funcionalidad en incremento
            WriteLine($" numero = numero + 20 => numero ={numero + 20}");
            WriteLine($" numero  += 20 => {numero += 20}");

            // Tiene la misma funcionalidad en decremento
            WriteLine($" numero = numero - 20 => numero ={numero - 20}");
            WriteLine($" numero  -= 20 => {numero -= 20}");


            // USANDO CICLO WHILE
            WriteLine("\n USANDO CICLO WHILE");

            int index = 1; //Hacer que cuente de 1 al 10 automaticamente
            while (index <= 10)
            {
                WriteLine($"index vale: {index}");
                index++;
            }

            // Permiti que la ventana de consola no se cierre.
            WriteLine("\nEnter close");
            _ = ReadLine();
        }
    }
}
