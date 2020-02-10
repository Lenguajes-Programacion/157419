using System;

namespace PracticaDos
{
    class Program
    {
        //Proyecto Calculadora

        static void Main(string[] args)
        {
            
            Console.WriteLine("---------Calculadora--------\n");
            too1

            bool close app = true;
            int value1 = 0;
            int value2 = 0;
            int result = 0;
            float result = 0;

            while (!close_app)
            {
                Console.WriteLine("Elije que operacion deseas realizar:\n");
                Console.WriteLine("EPulsa + para sumar \n");
                Console.WriteLine("Pulsa - para restar \n");
                Console.WriteLine("Pulsa x para multiplicar \n");
                Console.WriteLine("Pulsa / para dividir \n");
                Console.WriteLine("Pulsa s para salir\n");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas sumar: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        break;

                    case "-":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas restar: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        break;

                    case "x":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas multiplicar: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        break;

                    case "/":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas dividir: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        break;

                    case "s":
                        Console.WriteLine("Gracias por usar mi app! \n ");
                        close_app = false;
                        break;
                    
                    default:
                        Console.WriteLine("La opcion elejida no es valida" + args[1]);
                        break;
                }

            }
            
        }

    }
}
