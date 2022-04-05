// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           

           int valor = Convert.ToInt32(Console.ReadLine());

           if(valor % 2 == 0) 
           {
               Console.WriteLine("{0} é Par",valor);

           }
           else Console.WriteLine("{0} é ímpar", valor);

           Console.WriteLine("Hello, World!");
        }
    }
    

}
