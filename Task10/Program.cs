Console.WriteLine("Введите трехзначное число");
if (99 < num && num < 999)
{
    Console.WriteLine(num / 10 % 10);
}
else 
{
    Console.WriteLine("Число не трехзначное");
}