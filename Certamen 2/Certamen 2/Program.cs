using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ArrayNum = new int[5];
            Console.WriteLine("***** EJERCICIO 1 *****");
            Console.WriteLine();

            for (int i = 0; i < ArrayNum.Length; i++)
            {                
                ArrayNum[i] = Validacion("un numero");
            }

            for (int i = 0; i < ArrayNum.Length; i++)
            {
                Console.WriteLine("Los numeros de arreglo son: " + ArrayNum[i]);
            }
                                 

            int num = Validacion("un numero");
            Console.WriteLine();
            Console.WriteLine("Valor ingresado por el usuario: " + num);
            Console.WriteLine("Resultado: ");
            for (int i = 0; i < ArrayNum.Length; i++)
            {
                if (num < ArrayNum[i])
                    Console.Write( ArrayNum[i] + " ");

            }

            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("***** EJERCICIO 2 *****");


            string[,] matriz = new string[8, 8];

            int aux = matriz.GetLength(0) / 2;
            int aux1 = matriz.GetLength(1) / 2;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == aux || i == aux - 1 || j == aux1 || j == aux1 - 1)
                    {
                        matriz[i, j] = "1";

                    }
                    else
                    {
                        matriz[i, j] = "O";
                    }
                }
            }

            ImprimirMatriz(matriz);
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine();
            Console.WriteLine("***** EJERCICIO 3 *****");
            var random = new Random();
            int[] arrayAleatorio = new int[10];

            for (int i = 0; i < arrayAleatorio.Length; i++)
            {
                
                arrayAleatorio[i] = random.Next(50,200);  

            }


            Console.WriteLine();
            ImprimeVector(arrayAleatorio);
            Console.WriteLine();
            Console.WriteLine("El mayor esta en la poscicion: " +BuscaMayor(arrayAleatorio));
            Console.WriteLine();
            Console.WriteLine("El menor esta en la posicion: "+BuscaMenor(arrayAleatorio));
            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }


        static int Validacion(string valida)
        {
            int cant;
            bool v1 = false;
           
                do
                {
                    Console.WriteLine($"ingresar {valida}");
                    v1 = int.TryParse(Console.ReadLine(), out cant);
                    if (cant < 0)
                    {
                        v1 = true;
                        Console.WriteLine("Debes Ingresar solo numeros positivos");

                    }
                } while (!v1);                    


            return cant;
        }


        static int BuscaMayor(int[] vector)
        {
            int mayor = 0;
            int posicion = -1;
            for (int i = 0; i < vector.Length; i++)
            {

                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                    posicion = i;
                }

            }
            return posicion;
        }

        static int BuscaMenor(int[] vector)
        {
            int menor = vector[0];
            int posicion = -1;
            for (int i = 1; i < vector.Length; i++)
            {

                if (vector[i] < menor)
                {
                    menor = vector[i];
                    posicion = i;
                }

            }
            return posicion;
        }

        static void ImprimeVector(int[] vector)
        {
            for (int i = 0; i < vector.GetLength(0); i++)
            {

                Console.Write(vector[i] + " ");
                ;
            }
        }

        static void ImprimirMatriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();
            }

        }

    }
}
