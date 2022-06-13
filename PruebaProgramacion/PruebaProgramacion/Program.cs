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
            string excepcion;
            do
            {
                try
                {
                    Console.WriteLine("INGRESA 3 NUMEROS POSITIVOS");

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

            } while (numero1 < 0 || numero2 < 0 || numero3 < 0 );

            c = NumeroMayor(numero1, numero2, numero3);

            a = NumerMenor(numero1, numero2, numero3);

            Console.ReadLine();
            Console.Clear();

            DiferenciaVariables(numero1, numero2, numero3);

            Console.ReadLine();
            Console.Clear();

            NumerosPares(a, c);

            Console.ReadLine();
            Console.Clear();

            NumerosImpares(c, a);

            Console.WriteLine("AQUI TERMINA EL PROGRAMA");
              
            Console.ReadKey();

        }

        public static int NumeroMayor(int a, int b, int c)
        {
            int res = 0;
            Console.WriteLine("\nNUMERO MAYOR");
            if (a > b && a > c)
            {
                res = a;
                Console.WriteLine($"El mayor es : {a} ");
            }
            else if (b > a && b > c)
            {
                res = b;
                Console.WriteLine($"El mayor es : {b} ");
            }
            else
            {
                res = c;
                Console.WriteLine($"El mayor es : {c} ");
            }

            return res;

        }
        public static int NumerMenor(int a, int b, int c)
        {
            int res = 0;
            Console.WriteLine("\nNUMERO MAYOR");
            if (a < b && a < c)
            {
                res = a;
                Console.WriteLine($"El Menor es : {a} ");
            }
            else if (b < a && b < c)
            {
                res = b;
                Console.WriteLine($"El Menor es : {b} ");
            }
            else
            {
                res = c;
                Console.WriteLine($"El Mneor es : {c} ");
            }

            return res;

        }
        public static void DiferenciaVariables(int a, int b, int c)
        {
            Console.WriteLine("\nDiferencias o rangos existentes entre variables");

            int resultado = 0;

            resultado = c - a;

            Console.WriteLine($"La diferencia entre C y A es :{resultado}\n");

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("Resultado pertenece al mes de: Enero\n");
                    break;
                case 2:
                    Console.WriteLine("Resultado pertenece al mes de: Febrero\n");
                    break;
                case 3:
                    Console.WriteLine("Resultado pertenece al mes de: Marzo\n");
                    break;
                case 4:
                    Console.WriteLine("Resultado pertenece al mes de: Abril\n");
                    break;
                case 5:
                    Console.WriteLine("Resultado pertenece al mes de: Mayo\n");
                    break;
                case 6:
                    Console.WriteLine("Resultado pertenece al mes de: Junio\n");
                    break;
                case 7:
                    Console.WriteLine("Resultado pertenece al mes de: Julio\n");
                    break;
                case 8:
                    Console.WriteLine("Resultado pertenece al mes de: Agosto\n");
                    break;
                case 9:
                    Console.WriteLine("Resultado pertenece al mes de: Septiembre\n");
                    break;
                case 10:
                    Console.WriteLine("Resultado pertenece al mes de: Octubre\n");
                    break;
                case 11:
                    Console.WriteLine("Resultado pertenece al mes de: Noviembre\n");
                    break;
                case 12:
                    Console.WriteLine("Resultado pertenece al mes de: Diciembre\n");
                    break;
                default:
                    Console.WriteLine("La opcion no coincide con ningun mes\n");
                    break;
            }

            resultado = b - a;

            Console.WriteLine($"La diferencia entre B y A es :{resultado}\n");

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("Resultado pertenece al dia: Lunes\n");
                    break;
                case 2:
                    Console.WriteLine("El esultado pertenece al dia: Martes\n");
                    break;
                case 3:
                    Console.WriteLine("El Resultado pertenece al dia: Miercoles\n");
                    break;
                case 4:
                    Console.WriteLine("El Resultado pertenece al dia: Jueves\n");
                    break;
                case 5:
                    Console.WriteLine("El Resultado pertenece al dia: Viernes\n");
                    break;
                case 6:
                    Console.WriteLine("El Resultado pertenece al dia: Sabado\n");
                    break;
                case 7:
                    Console.WriteLine("El Resultado pertenece al dia: Domingo\n");
                    break;
                default:
                    Console.WriteLine("El valor no Coincide con ningun dia\n");
                    break;

            }

            resultado = b - c;

            Console.WriteLine($"La diferencia entre B y C es :{resultado}\n");
        }
        public static void NumerosPares(int a, int c)
        {
            Console.WriteLine("Numeros pares Entre A y C");
            int i = 0;
            for ( i = a; i <= c; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Los numeros pares son: {i}");
                }

            }

            
        }
        public static void NumerosImpares(int c, int a)
        {
            Console.WriteLine("\nNumeros Impares Entre C y A");

            for (int i = c; i >= a; i--)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine($"Los numeros Impar son: {i}");
                }

            }
        }

    }

        
    }
