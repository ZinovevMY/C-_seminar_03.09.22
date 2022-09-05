//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int number = new Random().Next(100,1000);
int newNumber = 0;

int RemoveSecondNum(int num)
{
    int num1 = num%10;
    int num2 = (num/100)*10 + num1;
    return num2; 
}

newNumber = RemoveSecondNum(number);
System.Console.WriteLine($"Число {number} после обработки стало {newNumber}");