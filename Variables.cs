using System;

public partial class Variables
{
    //Creamos una constante enumerada llamada DiaSemana que albergue los días y les asignamos un valor. Se les puede hacer referencia con el método GetName
    enum DiaSemana {Lunes=1, Martes=2, Miercoles=3, Jueves=4, Viernes=5, Sábado=6, Domingo=7  } 
    
    /*
     Crea un programa en C# que solicite por teclado dos números e indique cuál es el mayor de ambos
     */
    public static void ElMayor()
    { 
            int numero1 = 0, numero2 = 0;
            bool comprobar = true;
            do
            {
                try
                {
                    Console.Write("Introduce un número entero: ");
                    numero1 = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor que has introducido no es un número entero.");
                }
            } while (!comprobar);
            do
            {
                try
                {
                    Console.Write("Introduce otro número entero: ");
                    numero2 = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor que has introducido no es un número entero.");
                }
            } while (!comprobar);

            if (numero1 < numero2) Console.WriteLine("{0} es menor que {1}", numero1, numero2);
            else if (numero1 > numero2) Console.WriteLine("{0} es mayor que {1}", numero1, numero2);
            else Console.WriteLine("{0} es igual a {1}", numero1, numero2);
            Console.ReadKey();

        }//fin class ElMayor

    /*
     Crea un programa que imprima por pantalla todos los números impares entre 0 y 100
     */

    public static void Impares()
    {
        for (int numeroimpar=1; numeroimpar<=100; numeroimpar += 2)
        {
            Console.Write("{0}, ",numeroimpar);
        }
        Console.WriteLine("\r\n\nOprime una tecla para continuar");
        Console.ReadKey();
    }//fin Impares

    /*
     Crear un programa donde el usuario ingrese un número del 1 al 7 y te indique qué día al que corresponde dicho número. 
    Recuerda que debes comprobar la validez del número introducido por teclado.
     */
    public static void Quediaes()
    {
        bool comprobar;
        short dia;
        Console.Clear();
        do
        {
            
            Console.WriteLine("Introduce el valor del que quieres adivinar en que día cae (1-7): ");
            comprobar = short.TryParse(Console.ReadLine(), out dia);
            if (!comprobar)
            {
                Console.WriteLine("No has introducido un número entero");
            }else if (dia<=0 || dia>=8){
                Console.WriteLine("El valor tiene que ser un número comprendido entre 1 y 7");
            }
        } while (!comprobar);
        Console.WriteLine("El valor {0} pertenece al {1}", dia, Enum.GetName(typeof(DiaSemana),dia));
    }




}
