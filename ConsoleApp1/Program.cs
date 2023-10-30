int num = 2;
Console.WriteLine("Четные числа кратные 5 от 2 до 100: ");
while (num <= 100)
{
    if (num % 2 == 0 && num % 5 == 0)
    {
        Console.WriteLine(num);
    }
    num++;
}
