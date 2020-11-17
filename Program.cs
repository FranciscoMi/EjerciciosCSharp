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
                Console.WriteLine("2- ¿Cuáles son los numeros impares entre 0 y 100?");
                Console.WriteLine("3- ¿Que día de la semana es?");
                Console.WriteLine("4- ¿Cuál es su valor Unicode?");
                Console.WriteLine("5- ¿Cuál es el valor de x en una ecuación de 2º grado?");
                Console.WriteLine("6- ¿Cuales son los 10 numeros que has introducido?");
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
                    case "4":
                        Variables.valorUnicode();
                        break;
                    case "5":
                        Variables.EcuacionesGrado2();
                        break;
                    case "6":
                        Variables.NumerosDiferentes();
                        break;
                }
            } while (eleccion != "0");
            Console.WriteLine("Nos vemos");
            Console.ReadKey();
        }//fin main

    }//fin class program
}
