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
            WriteLine($"{4} != {5}? : {4 != 5}");  //4  es diferente 5 -> yes or true


            // Permiti que la ventana de consola no se cierre.
            WriteLine("\nEnter close");
            _ = ReadLine();
        }
    }
}
