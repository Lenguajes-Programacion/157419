﻿using System;

namespace PracticaDos
{
    class Program
    {
        //Proyecto Calculadora

        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "+":
                    Console.WriteLine("Es una suma");
                    break;
                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido:" + args[1]);
                    break;
            }
            
        }

    }
}