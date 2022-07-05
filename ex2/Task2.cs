// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace Homework4
{
    class Task2
    {
      public static void Main(string[] args)
      {
        Console.WriteLine ("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int SumNumber(int number)
        {
          int counter = Convert.ToString(number).Length;
          int prior = 0;
          int result = 0;
            for (int i = 0; i < counter; i++)
            {
             prior = number - number % 10;
             result = result + (number - prior);
             number = number / 10;
            }
          return result;
        }
        int sumNumber = SumNumber(number);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);
      }
    }
}