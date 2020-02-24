using System;

namespace PracticaDos
{
    class Program
    {
        //Proyecto Calculadora

        static void Main(string[] args)
        {
            
            Console.WriteLine("---------Calculadora--------\n");

            bool close app = true;
            int value1 = 0;
            int value2 = 0;
            int result = 0;
            float result = 0;

            while (close_app)
            {
                Console.WriteLine("Elije que operacion deseas realizar:\n");
                Console.WriteLine("Pulsa + para sumar \n");
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
                        result = Calculus.suma(value1,value2);
                        Console.WriteLine("El valor de tu resultado es: {0} \n ", result)
                        Console.WriteLine("Si deseas realizar otra operacion pulsa 1 \n ");
                        Console.WriteLine("Para salir del programa pulsa 2 \n ");
                        break;

                    case "-":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas restar: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        result = Calculus.suma(value1,value2);
                        Console.WriteLine("El valor de tu resultado es: {0} \n ", result);
                        Console.WriteLine("Si deseas realizar otra operacion pulsa 1 \n ");
                        Console.WriteLine("Para salir del programa pulsa 2 \n ");
                        break;

                    case "x":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas multiplicar: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        result = Calculus.suma(value1,value2);
                        Console.WriteLine("El valor de tu resultado es: {0} \n ", result);
                        Console.WriteLine("Si deseas realizar otra operacion pulsa 1 \n ");
                        Console.WriteLine("Para salir del programa pulsa 2 \n ");
                        break;

                    case "/":
                        Console.WriteLine("A continuacion ingresa los 2 numeros que deseas dividir: \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("A continuacion ingresa el segundo valor: \n ");
                        value2 = int.Parse(Console.ReadLine());
                        result = Calculus.divide(value1,value2);
                        Console.WriteLine("El valor de tu resultado es: {0} \n ", result);
                        Console.WriteLine("Si deseas realizar otra operacion pulsa 1 \n ");
                        Console.WriteLine("Para salir del programa pulsa 2 \n ");
                        break;

                    case "r":
                        Console.WriteLine("Si deseas realizar otra operacion pulsa 1 \n ");
                        Console.WriteLine("A continuacion ingresa el primer valor: \n ");
                        
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

    class Calculus
    {
        public static int suma(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 + valor2;
            return result;
        }
        public static int resta(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 - valor2;
            return result;
        }
        public static int multi(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 * valor2;
            return result;
        }
        public static int division(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 / valor2;
            return result;
        }
    }


}
