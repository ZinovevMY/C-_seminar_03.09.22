//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(10,99);
int i = number;
int tmp = i%10;
int max = 0;

while (i > 0)
{
    if (tmp > max)
    {
        max = tmp; 
    }
    i = i/10;
    tmp = i%10;

}

System.Console.WriteLine(number);
System.Console.WriteLine(max);