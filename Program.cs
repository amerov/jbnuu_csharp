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
                case "2":
                    Console.WriteLine("Введите калорийность продукта в 100 граммах");
                    int caloric = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите вес продукта в граммах");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    var task1 = new Solutions.Task1(caloric, weight);
                    var result = task1.Calculate();
                    Console.WriteLine(result);
                    break;
                case "3":
                    Console.WriteLine("Введите количество часов");
                    var hours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество минут");
                    var minutes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество секунд");
                    var seconds = Convert.ToInt32(Console.ReadLine());
                    var task2 = new Solutions.Task2(hours, minutes, seconds);
                    Console.WriteLine($"количество секунд: {task2.CalculateSeconds()}");
                    Console.WriteLine($"+ 5 секунд: {task2.Add5Sec()}");
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