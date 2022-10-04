
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

            //Console.WriteLine("Give your name: ");
            //string? name = Console.ReadLine();
            //Console.Write("Give your age: ");
            //int? age = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Give your city: ");
            //string? city = Console.ReadLine();
            //Console.Write("Give your profession: ");
            //string? profession = Console.ReadLine();

            //Console.WriteLine($"Hello {name}, your age is {age}, you live in {city} and your profession is {profession}");

            /*
             * 
             * Ejercicio 2

             * Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

             * Coche: puertas, ruedas, marca, ITV vigente vigente

             * Mesa: peso, largo, material, color

             */

            
            string puertas = "puertas de acero";
            string ruedas = "ruedas de carbono";
            string marca = "Chevrolet";
            bool ITVvigente = true;
            Console.WriteLine("------------------------------------------DATOS DEL COCHE------------------------------------------\n"+ 
            $"El choche tiene {puertas}, {ruedas}, es de marca {marca} y el ITV vigente es {ITVvigente}");

            float peso = 150.55f; //kg
            int largo = 2; //m
            string material = "Madera";
            string color = "marrón";

            Console.WriteLine("\n-----------------------------------------DATOS DE LA MESA-----------------------------------------\n" +
            $"El peso de la mesa es de {peso} kg, el largo es de {largo} m, el material es {material} y es de color {color}");


            /**
             * 
             *   Ejercicio 3

             *   Operadores Determina los operadores para verificar las siguientes condiciones:

             *   Un número es mayor o igual a 18

             *   Un char es ‘a’

              *  Se cumplen dos conciones a la vez (ambas verdaderas)

             *   Se cumple una de dos condiciones a la vez (una true y otra false)
             */

            int i = 10;
            Console.WriteLine($"\nUn número es mayor o igual a 18: {i} >= 18 - " + (i >= 18));

            // Condiciones verdaderas
            Console.WriteLine($"Condiciones verdaderas " + (i < 20 && i > 5));

            // Condicion true y false
            Console.WriteLine($"Condicion true y false " + (i < 40 && i < 5));
        }



    }
}














