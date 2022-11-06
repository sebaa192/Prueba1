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
            //CREACION CARGO
            Cargo cargo = new Cargo();
            cargo.idcargo = 007;
            cargo.nombreCargo = "Auxiliar";

            //CREACION REGION
            Region region = new Region();
            region.codigoRegion = 01;
            region.nombreRegion = "Bio BIo";

            //CREACION SUCURSAL
            Sucursal sucursal = new Sucursal();
            sucursal.codigoSucursal = 001;
            sucursal.nombre = "Los Angeles";
            string nombreRe = region.mostrarRegion(region);

            //CREACION DEPARTAMENTO
            Departamento departamento = new Departamento();

            departamento.codigodepa = 001;
            departamento.nombredepa = "Aseo";
            
            //CREACION JEFE
            Jefe jefe = new Jefe(40, "Manuel Rojas");
            

            //CREACION EMPLEADO
            Personal empleado = new Personal();
            empleado.codEmpleado = 50;
            empleado.Nombre = "Juan ";
            empleado.Apellido = "Perez";
            string nombreCargo = empleado.mostrarCargo(cargo);
            string nombreJe = empleado.mostrarJefe(jefe);
            string nombreDepto = empleado.mostrarDepartamento(departamento);


            Console.WriteLine("EMPLEADO AGREGADO");
            Console.WriteLine();
            Console.WriteLine($"Codigo Empleado: {empleado.codEmpleado}\nNombre:{empleado.Nombre}\nApellido: {empleado.Apellido}\nCargo: {nombreCargo}\nJefe: {nombreJe}\nDepartamento: {nombreDepto}");
            


           

            Console.ReadLine();

            Console.ReadKey();  

        }
    }
}
