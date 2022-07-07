// Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]

using System;

namespace Homework4
{
  class Task3
  {
    public static void Main(string[] args)
    {
      Random rand = new Random();
      int A = rand.Next(5, 11);
      
      int[] numArray = new int[A];
      Console.Write("Случайный массив:");

      Random rand2 = new Random();
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = rand2.Next(40);
                Console.Write(numArray[i] + " ");
            }
      Console.Write("Случайные числа массива в квадрате:");
          foreach (int number in numArray)
           {
             Console.Write(Math.Pow(number, 2) + " ");
           }
    }
  }
}



