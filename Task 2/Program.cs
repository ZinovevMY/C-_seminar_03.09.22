//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
void CheckMultiplicity(int num1, int num2)
{
    if (num1%num2 == 0)
    {
        System.Console.WriteLine($"Число {num1} кратно числу {num2}");
    }
    else
    {
        System.Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток от деления равен {num1%num2}");
    }
}

int firstNum = Prompt("Введите первое число: ");
int secondNum = Prompt("Введите второе число: ");

if (secondNum > firstNum)
{
    if (firstNum != 0)
    {
        CheckMultiplicity(secondNum,firstNum);
    }
    else
    {
        System.Console.WriteLine("На ноль делить нельзя!");
    }
}
else 
{
    if (secondNum != 0)
    {
        CheckMultiplicity(firstNum,secondNum);    
    }
    else
    {
        System.Console.WriteLine("На ноль делить нельзя!");
    }
}
