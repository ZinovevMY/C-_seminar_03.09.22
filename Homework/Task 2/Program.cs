//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetThirdNumber(int num)
{
    int i = num;
    int result = 0;
    if(num > 999)
    {
        while (i > 0)
        {
            i = i/10;
            if (i < 1000)
            {
                result = i%10;
                break;
            }
        }
    return result;
    }
    if (num > 99 && num < 1000)
    {
        return result = num%10;
    }
    else
    {
        return result = -1;
    }
}
int number = Math.Abs(Prompt("Введите число: "));
int thirdNumber = GetThirdNumber(number);
if (thirdNumber == -1)
{
    System.Console.WriteLine("Третьей цифры нет.");
}
else
{
    System.Console.WriteLine($"Третья цифра в числе {number} это {thirdNumber}");    
}

