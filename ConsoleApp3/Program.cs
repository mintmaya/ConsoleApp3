using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace ConsoleApp3
{
     class Program
    {
        static void Main(string[] args)
        {
            Person func = new Person();
            func.Hello("Irina");
            
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.ReadLine();
          
            
            void name()
            {
                Console.WriteLine("How do u doing?");
                Console.ReadLine();
            }

            name();
            string GetMessage()
            {
                return "What is ur name?";
                
            }

            string message = GetMessage();  
            Console.WriteLine(message);
            Console.ReadLine();

            int Sum(int x, int y)
            {
                return x + y;
            }

            int result = Sum(1345, 1345);  
            Console.WriteLine(result);   

            Console.WriteLine(Sum(55678, 676));

            void PrintPerson(string nam, int age)
            {
                if (age > 120 || age < 1)
                {
                    Console.WriteLine("Du hust");
                    return;
                }
                Console.WriteLine($"Имя: {nam}  Возраст: {age}");
            }

            PrintPerson("Alena", 18);  
        }
    }
}
