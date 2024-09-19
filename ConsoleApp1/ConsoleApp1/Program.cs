using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un vendedor de MiEmpresa SA recibe un salario bruto más un extra como comisión de
ventas de la siguiente manera: Si vendió hasta 600 soles gana 5% sobre la venta, si vendió
más de 600 hasta 3000 soles gana 7%, pero si vendió más de 3000 soles entonces ganará 300
soles más 6% de las ventas.
Además, sobre el total ganado (sueldo bruto + comisión) se le descontará por concepto de
impuestos según esta relación: si tiene 3 o menos años en la empresa se descuenta 6.5%, si
tiene 4 a más años se descuenta 4.5%
Al ejecutar el programa debe solicitar su nombre, su salario bruto del mes, las ventas
realizadas y la cantidad de años en la empresa. Calcule y muestre: su nombre, el total
ganado, el descuento en dinero y el salario neto que recibirá.
Haga una prueba con estos datos:
 Nombre: su primer nombre
 Salario bruto: 2100
 Ventas: 1800*/
            string nombre;
            int bruto, años, venta;
            double extra;
            Console.WriteLine("[=========================MI EMPRESA S.A=========================]");
            Console.Write("Ingresé el nombre del trabajador: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresé el salario bruto del trabajador: ");
            bruto = int.Parse(Console.ReadLine());
            Console.Write("Ingresé la venta del trabajador: ");
            venta = int.Parse(Console.ReadLine());
            if (venta<=600) {
                extra=venta * 0.05;
            }
            if (venta <= 3000)
            {
                extra = venta * 0.07;
            }
            Console.Write("Ingresé la cantodad de años del trabajador: ");
            años = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
