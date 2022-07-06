// Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]

using System;

namespace Homework4
{
  class Task3
  {
    private static void Main(string[] args)
    {
      int[] numArray = new int[10];
      Console.Write("Случайный массив:");
      Random rand = new Random();
      for (int i = 0; i < numArray.Length; i++)
        {
          numArray[i] = rand.Next(40);
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



