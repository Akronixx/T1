﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Haga un programa en C# sobre el control del tráfico de carros:
El Dpto. de Tránsito y Seguridad Vial desea saber de los “n” autos que entran a la ciudad de
Lima, cuantos entran con calcomanía de cada color. Conociendo el último dígito de la placa
de cada automóvil se puede determinar el color de la calcomanía utilizando la siguiente
relación:
 0-3: Verde
 4-6: Azul
 7-9: Rojo
 F: Fin
El programa funcionará hasta que se digite F, mostrando cuantos entraron por cada color
Hará una prueba con estos datos: 2, 3, 4, 6, 9, F*/
            string n;
            double placa;
            Console.WriteLine("[=============================CONTROL DE TRAFICO=============================]");
            Console.WriteLine("Desea saber la calcomanía del vehículo: ");
            n= Console.ReadLine().ToUpper();
            while (n!="S" && n!="F")
            {
                Console.Write("Errooooooor ingresé una opción valida!!!!!!");
                Console.WriteLine("Desea saber la calcomanía del vehículo: ");
                n = Console.ReadLine().ToUpper();
            }
            while (n == "S")
            {
                Console.Write("Ingresé el ultimo digito de la placa del vehiculo: ");
                placa = int.Parse(Console.ReadLine());
            }
        }
    }
}
