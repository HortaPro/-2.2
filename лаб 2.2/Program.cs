// Миронова Анастасия 22-ИСП-2/1
// Вариант 4 высокий уровень

try
{
    int number, n = 0;

    Console.Write("Введите число от 1 до 99:");
    number = int.Parse(Console.ReadLine());

    if (number >= 11 && number <= 14) Console.WriteLine($"{number} копеек");

    if (number != 11 && number != 12 && number != 13 && number != 14) 
    {
        n = number % 10;
        if (n == 1) Console.WriteLine($"{number} копейка");
        else if (n <= 4) Console.WriteLine($"{number} копейки");
        else if (n <= 9) Console.WriteLine($"{number} копеек");
        else if (n == 0) Console.WriteLine($"{number} копеек");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}