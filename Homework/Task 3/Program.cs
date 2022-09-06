//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsHoliday(int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int weekDay = Prompt("Введите день недели: ");
if (weekDay < 1 || weekDay > 7)
{
    System.Console.WriteLine("Нет такого дня недели!");
}
else
{
    if (IsHoliday(weekDay))
    {
        System.Console.WriteLine("Это выходной!");
    }
    else
    {
        System.Console.WriteLine("Это будний день!");
    }
}
