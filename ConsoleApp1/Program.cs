using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Знайти :\n1 суму від’ємних елементів масиву  \n2 максимальний серед парних елементів масиву; \n3 добуток елементів масиву, що мають парні індекси; \n4 номер (індекс) максимального елемента масиву;\n5 максимальний за модулем елемент масиву; \n6 суму індексів додатних елементів;\n7 кількість непарних елементів масиву.");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество елементов = ");
            int n = int.Parse(Console.ReadLine());
            int [] arr = ClassLibrary1.Class1.randomArr(n);

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]} ");

            }

            switch (b)
            {
                case 1:
                    int max = ClassLibrary1.Class1.task1(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
                case 2:
                     max = ClassLibrary1.Class1.task2(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
                case 3:
                     max = ClassLibrary1.Class1.task3(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
                case 4:
                     max = ClassLibrary1.Class1.task4(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
                case 5:
                     max = ClassLibrary1.Class1.task5(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
                case 6:
                     max = ClassLibrary1.Class1.task6(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
                case 7:
                     max = ClassLibrary1.Class1.task7(arr);
                    Console.WriteLine($"sum = {max}");
                    break;
            }
            

        }
    }
}
