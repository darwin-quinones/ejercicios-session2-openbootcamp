
using System;
namespace ejerciciosSession2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            * 
            * Ejercicio 1
            * Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para
            *cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
            */

            Console.WriteLine("Give your name: ");
            string? name = Console.ReadLine();
            Console.Write("Give your age: ");
            int? age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Give your city: ");
            string? city = Console.ReadLine();
            Console.Write("Give your profession: ");
            string? profession = Console.ReadLine();

            Console.WriteLine($"Hello {name}, your age is {age}, you live in {city} and your profession is {profession}");

            /*
             * 
             * Ejercicio 2

             * Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

             * Coche: puertas, ruedas, marca, ITV vigente

             * Mesa: peso, largo, material, color

             */

            string coche = "spark gt";
            string puertas = "puertas de acero";
            string ruedas = "ruedas de carbono";
            string marca = "Chevrolet";


        }



    }
}














