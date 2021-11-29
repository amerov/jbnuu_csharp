using System;

namespace MyApp

{
    class Program
    {
        static void Main() {
            hello();
            runSolution();
        }

        private static void runSolution() {
            string sol = Console.ReadLine();
            Console.WriteLine(sol);
            switch (sol)
            {
                case "1":
                    Console.WriteLine("Вызов публичного метода");
                    var mod1 = new Solutions.Modificators();
                    Console.WriteLine(mod1.GetNextValue());

                    Console.WriteLine("Вызов protected из наследника");
                    var mod2 = new Solutions.Modificators.MySubClass();
                    Console.WriteLine(mod2.Method2());

                    break;
                default:
                    Console.WriteLine("Неверные вводные данные. Попробуйте еще раз.");
                    runSolution();
                    break;
            }
        }

        private static void hello() {
            Console.WriteLine("Привет! Выберите решение");
            Console.WriteLine("1. Модификаторы доступа");
            Console.WriteLine("2. Задание 1");
            Console.WriteLine("3. Задание 2");
        }
    }
}