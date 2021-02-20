using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string día;
            Console.WriteLine("ingrese un día con inicial minuscula ");
            día = Console.ReadLine();
            switch (día)
            {
                case "lunes": Console.WriteLine("el lunes es día laboral"); break;
                case "martes": Console.WriteLine("el martes es día laboral"); break;
                case "miercoles": Console.WriteLine("el miercoles es día laboral"); break;
                case "jueves": Console.WriteLine("el jueves es día laboral"); break;
                case "viernes": Console.WriteLine("el viernes es día laboral"); break;
                case "sabado": Console.WriteLine("el sabado no es día laboral"); break;
                case "domingo": Console.WriteLine("el domingo no es día laboral"); break;
                default: Console.WriteLine("no es un día"); break;
            }
            Console.ReadKey();
        }
        }
    }
