using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;

namespace Lesson04_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Title="METODOS EN C#8";

            //1. METODOS VOID: 
            //Metodos que realizan una operacion dada pero no retornan ningun dato
            
            WriteLine("METODOS VOID");
            WriteLine("---------------------------------");

            Saludar();



            //2. METODOS RETORNAN UN DATO:
            //Son metodos que operan datos y retornan un solo tipo de dato obligatorio.

            WriteLine("\nMETODOS CON PARAMETROS Y RETORNO");
            WriteLine("---------------------------------");

            WriteLine("OperacionesBasicas(valorA,valorB,'operacion') \n");

            WriteLine($"{20} + {10}: " + OperacionesBasicas(20,10,"suma")); 
            WriteLine($"{20} - {10}: " + OperacionesBasicas(20,10,"resta"));
            WriteLine($"{20} / {10}: " + OperacionesBasicas(20,10,"dividir"));
            WriteLine($"{20} * {10}: " + OperacionesBasicas(20,10,"multiplicar"));


            //3  EXPRESION CUERPO METODO: 
            // Permite que un metodo sea leido como una expresion y asignado a una variable

            WriteLine("\nMETODOS CON CUERPO EXPRESION");
            WriteLine("---------------------------------");

            int numeroIncrementado = AgregarDosUnidades(10);
            WriteLine("Valor real: 10 \n" + $"Valor Incrementado: {numeroIncrementado}");

            //4 METODOS CON SWTICH: 
            //Se puede optimizar la utilidad de los if multiples con el uso de swtich

            WriteLine("\nMETODOS CON SWITCH");
            WriteLine("---------------------------------");

            WriteLine("Operaciones(valorA , valorB ,'operacion') \n");
            WriteLine($"{20} + {10}: " + Operaciones(20, 10, "suma"));
            WriteLine($"{20} - {10}: " + Operaciones(20, 10, "resta"));
            WriteLine($"{20} / {10}: " + Operaciones(20, 10, "dividir"));
            WriteLine($"{20} * {10}: " + Operaciones(20, 10, "multiplicar"));
            WriteLine($"{20} * {10}: " + Operaciones(20, 10, 10));


            //5 METODO PARAMETRO SALIDA
            // Todos metodo tiene parametros de entrada que reciben los datos  para ser operados
            //Existe la posibilidad de recibir parametros de salida que al efectuarse una 
            //Operacion el valor se asignara al param salida y poder ser usado fuera del metodo.

            WriteLine("\nMETODOS CON PARAMETROS SALIDA {OUT}");
            WriteLine("---------------------------------");

            int valorA = 20;
            int valorB = 10;

            OperacionSumar(valorA, valorB, out int suma, out int resta);
            WriteLine($"{valorA} + {valorB}: {suma} ");
            WriteLine($"{valorA} - {valorB}: {resta} ");


            //5 METODO CON TRY CATCH
            // Metodos que implementan try and catch dentro de su cuerpo pueden mejorar 
            // la robuztes de las mismas ante cualquier evento 

            WriteLine("\nMETODOS CON TRY CATCH");
            WriteLine("---------------------------------");

            int result = OperacionDividir(60, 30);
           
            OperacionDividir(60, 20);

            WriteLine($"{60} / {20} = {OperacionDividir(60,20)}");
            WriteLine($"{60} / {30} = {result}");



            //6 METODO CON TUPLAS


            string cadena = "Jorge Baltodano,45";
            string cadena1 = "Luisandro Castillejos,20";
            string cadena2 = "Fio,33";

           // Primera forma : Forma manual
            WriteLine(cadena.Substring(0, 15));
            WriteLine(cadena.Substring(16)); ;

            //Segunda Forma : Usando IndexOf
            WriteLine("-------------------");
            WriteLine(cadena1.Substring(0, cadena1.IndexOf(","))); // Obtengo nombres
            WriteLine(cadena1.Substring(cadena1.IndexOf(",") + 1));

            //Tercera Forma : Implementar Tuplas
            WriteLine("-------------------");
            WriteLine($"{ObtieneDatos(cadena).name} \n {ObtieneDatos(cadena).age}");
            WriteLine($"{ObtieneDatos(cadena1).name} \n {ObtieneDatos(cadena1).age}");
            WriteLine($"{ObtieneDatos(cadena2).name} \n {ObtieneDatos(cadena2).age}");



            WriteLine("Enter close");
            _= ReadKey();
        }

        public static int OperacionDividir(int valorA, int valorB)
        {
            int resultado = 0;
            try
            {

                resultado = valorA / valorB;
            }

            #region Excepciones
            catch (DivideByZeroException e)
            {
                WriteLine("Error dividir cero", e);
            }
            catch (NullReferenceException e)
            {
                WriteLine("Referencia vacia", e);
            }
            catch (FormatException e)
            {
                WriteLine("Formato incorrecto",e);
            }

            #endregion

            return resultado;

        }

        private static void OperacionSumar(int valorA, int valorB, out int suma, out int resta)
        {
            suma = valorA + valorB;
            resta = valorA - valorB;
        }

        public static int AgregarDosUnidades(int numero) => numero + 2;



        public static (string name, string age) ObtieneDatos(string cadena)
        {
            string name = cadena.Substring(0, cadena.IndexOf(","));
            string age = cadena.Substring(cadena.IndexOf(",") + 1);
            return (name, age);
        }

        public static void Saludar()
        {
            WriteLine("Hola, soy un metodo void..!");
        }
  
        //Suma,   Resta, Multiplica y Divide 
        public static int OperacionesBasicas(int valorA, int valorB, string operacion)
        {
            int resultado = 0;
            //Este metodo suma enteros y da un entero como respuesta
            if (operacion == "suma") { resultado = valorA + valorB; }
            else if (operacion == "resta") { resultado = valorA - valorB; }
            else if (operacion == "dividir") { resultado = valorA / valorB; }
            else if (operacion == "multiplicar") { resultado = valorA * valorB; }
            else { WriteLine("Operacion incorrecta..!"); }
            
            return resultado;
        }

        //Operacion con cuerpo de expresion
        public static int Operaciones(int valorA, int valorB, object operacion)
        {
            switch (operacion)
            {
                case string s when s == "suma": return valorA + valorB;
                case string s when s == "resta": return valorA - valorB;
                case string s when s == "dividir": return valorA / valorB;
                case string s when s == "multiplicar": return valorA * valorB;
                default: return 0 ;
            }
        }
    }
}
