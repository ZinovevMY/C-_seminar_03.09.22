
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Prompt($"Введите {i}-е число: ");
}

System.Console.WriteLine($"Сумма всех элементов массива равна {numbers.Sum()}, а их среднее арефмитическое равно {numbers.Average()}");