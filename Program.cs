﻿/* Bibliography:
singleton --> https://csharpindepth.com/articles/singleton
lock -->  https://www.altcontroldelete.pl/artykuly/wielowatkowosc-w-c-synchronizacja-watkow-cz-1-lock-monitor-mutex-/
sealed --> https://www.devtective.pl/nie-dziedzicz-tego-czyli-modyfikator-sealed-w-jezyku-c/
Thread Safety --> http://web.mit.edu/6.031/www/fa17/classes/20-thread-safety/

*/

using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton1 test;
            test = Singleton1.Instance;
            Singleton2 test1;
            test1 = Singleton2.Instance;


        }
    }
}