using System;
using System.Globalization;
using System.Text;

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
        //Aprovecho que he creado una constante enumerada llamada Diasemana para evitar hacer un switch hasta 7 veces
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
        //Con Enum.GetName hago la llamada a la enumeración "DiaSemana". El cual añade el tipo de la constante enumerada con typeof según el valor que le señalo en la variable "dia"
        Console.WriteLine("El valor {0} pertenece al {1}", dia, Enum.GetName(typeof(DiaSemana),dia));
    }//fin clase Quediaes()

    //Escribe un programa que lea una cadena de caracteres y a continuación visualice el símbolo y el valor Unicode de cada uno de los caracteres de la cadena.
    public static void valorUnicode()
    {
        string cadena=" ";
        bool comprobar = true; ;
        do
        {
            Console.WriteLine("Introduce una cadena de caracteres: ");
            //try{....}catch(Exception e){....} controla los errores que puedan surgir al introducir un valor
            try
            {
                cadena=Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine("No has introducido una cadena de caracteres válida");
                Console.WriteLine(e.Message);
                comprobar = false;
            }
        } while (!comprobar);
     //Leemos la cadena y la separamos en un array de caracteres
        //Trim() nos elimina los espacios en blanco a ambos lados de la cadena.
        cadena = cadena.Trim();
        //Generamos un array de caracteres que albergue cada uno de los caracteres de la cadena introducida. 
        //ToCharArray() convierte un string en una cadena de caracteres.
        char[] caracter = cadena.ToCharArray();
        //"cadena.Length" devuelve el tamaño de la cadena caracter por caracter
        Console.WriteLine("Caracter\tValor Unicode");
        for (int i = 0; i < cadena.Length; i++)
        {
            //Para hallar el valor Unicode de cada caracter no tenemos más que convertir char en int y luego hacer la transformación en hexadecimal con ToString("X4") 
            //X--> hexadecimal X4-->Hexadecimal con 4 valores
            int numero = (int)caracter[i];
            Console.WriteLine("{0} \t\t \\u{1}",caracter[i], numero.ToString("X4"));
        }
        Console.WriteLine("Oprime una tecla para volver al menú");
        Console.ReadKey();

    }//fin clase valorUnicode()


}
