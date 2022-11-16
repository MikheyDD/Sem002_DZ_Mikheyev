Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int numLength = num;
while (numLength != 0)
    {
        numLength = numLength / 10;
        count++;
    }
if (count < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (count != 3)
    {
        num = num / 10;
        count = count - 1;
    }
Console.WriteLine(num % 10); 
}