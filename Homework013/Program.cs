// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int FindThirdNumberOfDigit(int number)
{
    int result = 0;
    if (number > 99)
    {
        int d = Convert.ToInt32(Math.Log10(number)) + 1;
        int buf = Convert.ToInt32(Math.Pow(10, d - 3));
        result = (number / buf) % 10;
        Console.WriteLine($"Третья цифра числа {number} это {result}");
    }
    else
    {
        Console.WriteLine($"У числа {number} нет третьей цифры.");
    }
    return result;
}

int thirdDigit = FindThirdNumberOfDigit(number);
