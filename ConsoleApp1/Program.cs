Console.Write("Введите значение от 1 до 3: ");
int x = int.Parse(Console.ReadLine());
switch(x)
{
    case 1:
        {
            int a = 10, b = 34, c = 65;
            if (a>107) Console.Write($"{a}>1101011");
            if (b > 107) Console.Write($"{b}>1101011");
            if (c > 107) Console.Write($"{c}>1101011");
            else Console.Write("Нет чисел которые больше чем 1101011");
        }
        break;
    case 2:
        {
            int a = 76, b = 18, c = 55;
            if (a > 107) Console.Write($"{a}>1101011");
            if (b > 107) Console.Write($"{b}>1101011");
            if (c > 107) Console.Write($"{c}>1101011");
            else Console.Write("Нет чисел которые больше чем 1101011");
        }
        break;
    case 3:
        {
            int a = 81, b = 75, c = 20;
            if (a > 107) Console.Write($"{a}>1101011");
            if (b > 107) Console.Write($"{b}>1101011");
            if (c > 107) Console.Write($"{c}>1101011");
            else Console.Write("Нет чисел которые больше чем 1101011");
        }
        break;
}