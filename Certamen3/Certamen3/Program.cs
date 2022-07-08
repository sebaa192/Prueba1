using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();
            List<data> datos = new List<data>();
            data[] arrayData = new data[200];
           

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');
                
                arrayData[contador] = new data();
                arrayData[contador].APERTURA = double.Parse(dataLinea[0]);
                arrayData[contador].MAXIMO = double.Parse(dataLinea[1]);
                arrayData[contador].MINIMO = double.Parse(dataLinea[2]);
                arrayData[contador].CIERRE = double.Parse(dataLinea[3]);

                
                
                line = sr.ReadLine();
                contador++;
            }


            double mayorApertura = arrayData[0].APERTURA;
            double menorApertura = arrayData[0].APERTURA;

            for (int i = 10; i < 190; i++)            {

                for (int j = i - 10; j <= i; j++)
                {                    
                   for (int k = i; k <= i + 10; k++)
                   {
                        if (arrayData[i].APERTURA > arrayData[k].APERTURA && mayorApertura > arrayData[k].APERTURA && arrayData[i].APERTURA > arrayData[j].APERTURA && mayorApertura < arrayData[j].APERTURA)
                        {
                            mayorApertura = arrayData[i].APERTURA;
                        }
                    }

                    
                }
                for (int j = i - 10; j <= i; j++)
                {                    
                   for (int k = i; k <= i + 10; k++)
                   {
                        if (arrayData[i].APERTURA < arrayData[k].APERTURA && menorApertura < arrayData[k].APERTURA && arrayData[i].APERTURA < arrayData[j].APERTURA && menorApertura > arrayData[j].APERTURA)
                        {
                            menorApertura = arrayData[i].APERTURA;
                        }
                    }
                   
                }

            }

            Console.WriteLine("****** APERTURA*******");
            Console.WriteLine("Maximo: " + mayorApertura);
            Console.WriteLine("Minimo: " + menorApertura);
            Console.WriteLine();


            double mayorMaximo = arrayData[0].MAXIMO;
            double menorMaximo = arrayData[0].MAXIMO;

            for (int i = 10; i < 190; i++)
            {

                for (int j = i - 10; j <=i ; j++)
                {
                    for (int k = i; k <= i + 10; k++)
                    {
                        if (arrayData[i].MAXIMO > arrayData[k].MAXIMO && mayorMaximo > arrayData[k].MAXIMO && arrayData[i].MAXIMO > arrayData[j].MAXIMO && mayorMaximo < arrayData[j].MAXIMO)
                        {
                            mayorMaximo = arrayData[i].MAXIMO;
                        }
                    }

                }
            
                for (int j = i - 10; j <= i ; j++)
                {
                    for (int k = i; k <= i + 10; k++)
                    {
                        if (arrayData[i].MAXIMO < arrayData[k].MAXIMO && menorMaximo < arrayData[k].MAXIMO && arrayData[i].MAXIMO < arrayData[j].MAXIMO && menorMaximo > arrayData[j].MAXIMO)
                        {
                            menorMaximo = arrayData[i].MAXIMO;
                        }

                    }

                }

            }
            Console.WriteLine("****** MAXIMO*******");
            Console.WriteLine("Maximo: "+mayorMaximo);
            Console.WriteLine("Minimo: " + menorMaximo);
            Console.WriteLine();

            double mayorMimimo = arrayData[0].MINIMO;
            double menorMinimo = arrayData[0].MINIMO;

            for (int i = 10; i < 190; i++)
            {

                for (int j = i - 10; j <= i; j++)
                {
                    for (int k = i; k <= i + 10; k++)
                    {
                        if (arrayData[i].MINIMO > arrayData[k].MINIMO && mayorMimimo > arrayData[k].MINIMO && arrayData[i].MINIMO > arrayData[j].MINIMO && mayorMimimo < arrayData[j].MINIMO)
                        {
                            mayorMimimo = arrayData[i].MINIMO;
                        }
                    }

                }
            
                for (int j = i - 10; j <= i; j++)
                {

                    for (int k = i; k <= i + 10; k++)
                    {
                        if (arrayData[i].MINIMO < arrayData[k].MINIMO && menorMinimo < arrayData[k].MINIMO && arrayData[i].MINIMO < arrayData[j].MINIMO && menorMinimo > arrayData[j].MINIMO)
                        {
                            menorMinimo = arrayData[i].MINIMO;
                        }

                    }

                }

            }
            Console.WriteLine("****** MINIMO*******");
            Console.WriteLine("Maximo: " + mayorMimimo);
            Console.WriteLine("Minimo: " + menorMinimo);
            Console.WriteLine();

            double mayorCierre = arrayData[0].CIERRE;
            double menorCierre = arrayData[0].CIERRE;

            for (int i = 10; i < 190; i++)
            {

                for (int j = i - 10; j <= i; j++)
                {

                    for (int k = i; k <= i + 10; k++)
                    {
                        if (arrayData[i].CIERRE > arrayData[k].CIERRE && mayorCierre > arrayData[k].CIERRE && arrayData[i].CIERRE > arrayData[j].CIERRE && mayorCierre < arrayData[j].CIERRE)
                        {
                            mayorCierre = arrayData[i].CIERRE;
                        }

                    }

                }
                for (int j = i - 10; j <= i; j++)
                {

                    for (int k = i; k <= i + 10; k++)
                    {
                        if (arrayData[i].CIERRE < arrayData[k].CIERRE && menorCierre < arrayData[k].CIERRE && arrayData[i].CIERRE < arrayData[j].CIERRE && menorCierre > arrayData[j].CIERRE)
                        {
                            menorCierre = arrayData[i].CIERRE;
                        }

                    }

                }

            }
            Console.WriteLine("****** CIERRE*******");
            Console.WriteLine("Maximo: " + mayorCierre);
            Console.WriteLine("Minimo: " + menorCierre);
            Console.WriteLine();


            Console.WriteLine();


            Console.ReadKey();
        }


    }
}
