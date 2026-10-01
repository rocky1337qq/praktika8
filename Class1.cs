Console.Write("Введите пароль: ");
string parol = Console.ReadLine();

bool estCifra = false;
bool estBolshaya = false;
bool estSpecial = false;

for (int i = 0; i < parol.Length; i++)
{
    if (char.IsDigit(parol[i]))
    {
        estCifra = true;
    }

    if (char.IsUpper(parol[i]))
    {
        estBolshaya = true;
    }

    if (!char.IsLetterOrDigit(parol[i]))
    {
        estSpecial = true;
    }
}

if (parol.Length >= 8 && estCifra && estBolshaya && estSpecial)
{
    Console.WriteLine("Пароль надёжный");
}
else
{
    Console.WriteLine("Пароль ненадёжный");
}
    }