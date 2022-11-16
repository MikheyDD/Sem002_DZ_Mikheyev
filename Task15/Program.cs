Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7)
{
    Console.WriteLine("Число вне заданного диапазона");
}
else
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Выходной");
    }
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine("Будний день");
    }
}