string povtor = "yes";

while (povtor == "yes")
{
    Random random = new Random();
    int zagadanoe = random.Next(1, 101);

    int popitki = 0;
    int chislo = 0;

    Console.WriteLine("Я загадал число от 1 до 100.");

    while (chislo != zagadanoe)
    {
        Console.Write("Введите число: ");
        chislo = Convert.ToInt32(Console.ReadLine());

        if (chislo < 1 || chislo > 100)
        {
            Console.WriteLine("Ошибка! Введите число от 1 до 100.");
            continue;
        }

        popitki++;

        if (chislo < zagadanoe)
        {
            Console.WriteLine("Больше");
        }
        else if (chislo > zagadanoe)
        {
            Console.WriteLine("Меньше");
        }
        else
        {
            Console.WriteLine("Угадал!");
            Console.WriteLine("Количество попыток: " + popitki);
        }
    }

    Console.Write("Хотите сыграть ещё раз? (yes/no): ");
    povtor = Console.ReadLine();
}
