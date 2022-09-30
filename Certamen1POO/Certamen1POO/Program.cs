using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaIPVG;


namespace Certamen1POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Region region = new Region();
            Region region1 = new Region(01,"Atacama");
           
            Sucursal sucursal = new Sucursal();

            Departamento departamento = new Departamento();

            departamento.codigodepa = 001;
            departamento.nombredepa = "Aseo";

            Jefe jefe = new Jefe();

            Cargo cargo = new Cargo();

            Console.WriteLine("INGRESAR EMPLEADO: ");
            Console.WriteLine();
            Console.Write("Ingresar el codigo del empleado: ");

            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingresar el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar el apellido del empleado: ");
            string apellido = Console.ReadLine();
            Console.WriteLine();

            Personal persona1 = new Personal(codigo,nombre,apellido);

            Console.WriteLine("DATOS DEL EMPLEADO: ");
            Console.WriteLine("El empleado ingresado es :");
            Console.WriteLine("Codigo Empleado: "+persona1.codEmpleado+"\nNombre: "+persona1.Nombre+"\nApellido: "+persona1.Apellido+"\nAera/Departamento: "+departamento.nombredepa+"\nJefe a cargo Departamento:"+jefe.nombre);
            Console.WriteLine();
            Console.WriteLine($"Sucursal {sucursal.nombre}, Ubicada en la region del {region.NombreRegion} ");
            Console.ReadLine();

                        
           
            Console.ReadKey();  

        }
    }
}
