/*
* Лабораторная работа 7. Упражнение 2. Обращение строки  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Test
    {
        static void Main()
        {

            //Utils utils = new Utils(); // Это вызовет ошибку компиляции
            /* 
             * Статические классы могут быть вызваны без создания новых экземляров классов.
             * Функционал класса Utils после добавления static не изменится
            */
            string message;

            // Get an input string 
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();

            // Reverse the string 
            Utils.Reverse(ref message);

            // Display the result 
            Console.WriteLine(message);
        }
    }
}
