//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
string value = System.Console.ReadLine();
char lastChar = value[value.Length - 1];

System.Console.WriteLine(lastChar);