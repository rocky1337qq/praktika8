Console.Write("Введите нечётное число строк: ");
int kolichestvo = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= kolichestvo; i += 2)
{
    int probely = (kolichestvo - i) / 2;

    for (int j = 0; j < probely; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = kolichestvo - 2; i >= 1; i -= 2)
{
    int probely = (kolichestvo - i) / 2;

    for (int j = 0; j < probely; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
    }