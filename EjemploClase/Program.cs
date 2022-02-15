// See https://aka.ms/new-console-template for more information
using System;
namespace EjemploClase
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pedro Luis";
            string lastname = "Sánchez Arce";
            //Escribir una sola línea con Write
            Console.Write("Pedro Luis");
            Console.Write("Sánchez Arce");
            Console.Write("No.Control");

            //Escribir con saltos de Línea
            Console.WriteLine("Pedro Luís");
            Console.WriteLine("Sánchez Arce");
            Console.WriteLine("No.Control");
            Console.WriteLine("19222006");

            //Escribir saltos de línea pero con tipos de datos impresación
            Console.WriteLine("Hola " + name);
            Console.WriteLine("Hola " + lastname);

            //Escribir por medio de RedLine con WriteLine
            Console.WriteLine("Hola , ingresa tu nombre");
            Console.WriteLine("Hola " + Console.ReadLine()+" bienvenido");
        }
    }
}









