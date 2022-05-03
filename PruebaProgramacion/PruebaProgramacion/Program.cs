using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

           
            try
            {
                Console.WriteLine("INGRESA 3 NUMEROSn POSITIVOS");

                Console.WriteLine("Ingresa el Primer n° :");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el Segundo n° :");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el Tercer n° :");
                numero3 = int.Parse(Console.ReadLine());
                
            }
            catch (Exception e)
            {

                Console.WriteLine($"La opcion Ingresada no es valida {e.Message}");
            }

            Console.WriteLine("\nNUMERO MAYOR");
            if (numero1 > numero2 && numero1 > numero3) 
            {
                c = numero1;
                Console.WriteLine($"El mayor es : {numero1} ");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                c = numero2; 
                Console.WriteLine($"El mayor es : {numero2} ");
            }
            else
            {
                c = numero3;
                Console.WriteLine($"El mayor es : {numero3} ");
            }


            Console.WriteLine("\nNUMERO MENOR ");

            if (numero1 < numero2 && numero1 < numero3)
            {
                a = numero1;
                Console.WriteLine($"El Menor es : {numero1} ");
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                a = numero2;
                Console.WriteLine($"El Menor es : {numero2} ");
            }
            else
            {
                a = numero3;
                Console.WriteLine($"El Menor es : {numero3} ");
            }

            Console.WriteLine("\nDiferencias o rangos existentes entre variables");

            int resultado = 0;

            resultado = c - a;

            Console.WriteLine($"La diferencia entre C y A es :{resultado}\n");

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("Resultado pertenece al mes de: Enero");
                    break;
                case 2:
                    Console.WriteLine("Resultado pertenece al mes de: Febrero");
                    break;
                case 3:
                    Console.WriteLine("Resultado pertenece al mes de: Marzo");
                    break;
                case 4:
                    Console.WriteLine("Resultado pertenece al mes de: Abril");
                    break;
                case 5:
                    Console.WriteLine("Resultado pertenece al mes de: Mayo");
                    break;
                case 6:
                    Console.WriteLine("Resultado pertenece al mes de: Junio");
                    break;
                case 7:
                    Console.WriteLine("Resultado pertenece al mes de: Julio");
                    break;
                case 8:
                    Console.WriteLine("Resultado pertenece al mes de: Agosto");
                    break;
                case 9:
                    Console.WriteLine("Resultado pertenece al mes de: Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Resultado pertenece al mes de: Octubre");
                    break;
                case 11:
                    Console.WriteLine("Resultado pertenece al mes de: Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Resultado pertenece al mes de: Diciembre");
                    break;
                default:
                    Console.WriteLine("La opcion no coincide con ningun mes");
                    break;
            }
            

            resultado = b - a;

            Console.WriteLine($"La diferencia entre B y A es :{resultado}\n");

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("Resultado pertenece al dia: Lunes");
                    break;
                case 2:
                    Console.WriteLine("El esultado pertenece al dia: Martes");
                    break;
                case 3:
                    Console.WriteLine("El Resultado pertenece al dia: Miercoles");
                    break;
                case 4:
                    Console.WriteLine("El Resultado pertenece al dia: Jueves");
                    break;
                case 5:
                    Console.WriteLine("El Resultado pertenece al dia: Viernes");
                    break;
                case 6:
                    Console.WriteLine("El Resultado pertenece al dia: Sabado");
                    break;
                case 7:
                    Console.WriteLine("El Resultado pertenece al dia: Domingo");
                    break;
                default:
                    Console.WriteLine("El valor no Coincide con ningun dia");
                    break;
                                       
            }

            resultado = b - c;

            Console.WriteLine($"La diferencia entre B y C es :{resultado}\n");


            Console.WriteLine("Numeros pares Entre A y C");

            for (int i = a; i <= c; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Los numeros pares son: {i}");
                }
                
            }

            Console.WriteLine("\nNumeros Impares Entre C y A");

            for (int i = c; i >= a; i--)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine($"Los numeros Impar son: {i}");
                }

            }

            
            Console.ReadKey();

        }

        
    }
}
