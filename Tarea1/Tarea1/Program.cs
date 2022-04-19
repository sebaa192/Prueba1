using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea1
{
    class Program
    {
        
        static void Main(string[] args)
        {





            Console.WriteLine("Ingrese un numero rut: ");
            string rut = Console.ReadLine();


            Console.WriteLine("Ingrese su nombre : ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido : ");
            string apellido = Console.ReadLine();


            Console.WriteLine("Ingrese su edad :");
            int edad = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ingrese su fecha de nacimiento :");

            Console.WriteLine("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes : ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año : ");
            int Año = int.Parse(Console.ReadLine());




            Console.Clear();

            Console.WriteLine(" RUT :" + rut);
            Console.WriteLine(" Nombre  :" + nombre + "" + apellido);
            Console.WriteLine(" Edad  :" + edad);
            Console.WriteLine("Dia : " + dia + " - Mes: " + mes + " - Año: " + Año);

            System.Console.ReadLine();

            Console.Clear();

            Console.WriteLine("CONVERSIONES");

            Console.WriteLine("VALORES INCIALES\n b1 : 1\n s1 : 10\n num : 200\n l1 : 3000000\n a : 'a'\n ed : 20\n alias : CR7\n double : 19.5\n  ");
            byte b1 = 1;
            short s1 = 10;
            int num = 200;
            long l1 = 3000000;
            char a = 'a';
            string ed = "20";
            string alias = "CR7";
            double d1 = 19.5;
            float f1;

            b1 = Convert.ToByte(num);
            num = Convert.ToInt32(l1);
            l1 = int.Parse(ed);
            f1 = Convert.ToSingle(d1);
            alias = Convert.ToString(a);


            Console.WriteLine("El valor de b1 : " + b1);
            Console.WriteLine("El valor de num : " + num);
            Console.WriteLine("El valor de l1 : " + l1);
            Console.WriteLine("El valor de f1 : " + f1);
            Console.WriteLine("El valor de alias : " + alias);




            System.Console.ReadLine();
            Console.Clear();

            Console.WriteLine("VALIDACIONES");

           
            try
            {

                Console.WriteLine("Ingrese Correctamente su nombre : ");
                string NomUsuario = Console.ReadLine();

                Console.WriteLine("Ingrese su peso : ");
                int peso = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese altura : ");
                Double altura = Double.Parse(Console.ReadLine());


                Console.WriteLine("Su nombre es :" + NomUsuario);
                Console.WriteLine("Su peso es :" + peso);
                Console.WriteLine("Su altura es :" + altura);
            }



            catch (Exception e)
            {

                Console.WriteLine("No fue posible validar su edad !! Error:" + e.Message);

            }
            Console.ReadLine();
            Console.ReadKey();
        }

        }

        
        }

       

