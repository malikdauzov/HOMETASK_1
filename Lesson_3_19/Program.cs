using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    }

    static bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();
        int length = numberStr.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberStr[i] != numberStr[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
