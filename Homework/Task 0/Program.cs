// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите 3-значное целое число: ");

System.Console.WriteLine($"Вторая цифра во введенном числе {number} равна {(number/10)%10}");