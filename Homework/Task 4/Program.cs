//Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool NumberMultiplicity (int num1, int num2)
{
    if (num1%num2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int multipleNumber = Prompt("Введите число для проверки кратности: ");
while (true)
{
    int number = new Random().Next(1,100);
    if (NumberMultiplicity(number,multipleNumber))
    {
        System.Console.WriteLine($"Сгенерированное число {number} кратно введенному числу {multipleNumber}.");
        break;
    }
    else
    {
        System.Console.WriteLine($"Сгенерированное число {number} не кратно введенному числу {multipleNumber}.");
    }
}
