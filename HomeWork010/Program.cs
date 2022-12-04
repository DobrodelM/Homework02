// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int GetRandomNumber(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}

int GetSecondDigitFromNumber(int number)
{
    int secondDigit = 0;
    secondDigit = (number % 100) / 10;
    return secondDigit;
}

int randomNumber = GetRandomNumber(100, 999);
int secondDigit = GetSecondDigitFromNumber(randomNumber);
Console.WriteLine($"В числе {randomNumber} второй цифрой являтся цифра {secondDigit}");

