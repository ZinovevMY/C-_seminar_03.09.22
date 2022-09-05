//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Введите натуральное целое число: ");
if (number%7 == 0 && number%23 == 0)
{
    System.Console.WriteLine("Введенное число кратно 7 и 23.");
}
else
{
    System.Console.WriteLine("Введенное число одновременно не кратно 7 и 23.");
}