using System;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HolaMundo.Hola();
            string eleccion= "[0-9]+"; //Con esta RegExp definimos que se pueden introducir de uno a varios números enteros
            do
            {
                Console.Clear();
                Console.WriteLine("\r\n---- Menú de Ejercicios ----");
                Console.WriteLine("1- ¿Cuál es el mayor de dos dígitos?");
                Console.WriteLine("2- ¿Cuál es el mayor de dos dígitos?");
                Console.Write("Elige opción del menú, [0] para salir: ");
                try
                {
                    eleccion = Console.ReadLine();
                    Console.WriteLine("\r\n"); //\r es retorno de carro, \n es salto de linea.
                }
                catch (Exception e)
                {
                    Console.WriteLine("Introduce el número del menú");
                }
                switch (eleccion)
                {
                    case "1":
                        Variables.ElMayor();
                        break;
                    case "2":
                        Variables.Impares();
                        break;
                    case "3":
                        Variables.Quediaes();
                        break;
                }
            } while (eleccion != "0");
        }//fin main

    }//fin class program
}
