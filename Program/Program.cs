Console.Write("Введите набор символов через знак (,): ");
string inStringSimvol = Console.ReadLine();

string[] arraySimvol = GetArrayStringConsole(inStringSimvol);

Console.WriteLine("Введенные символы: ");
Print(arraySimvol);

Console.WriteLine("Введенные символы длиной меньше либо равны 3: ");
Print(GetArrayThreeSimvol(arraySimvol));

Console.WriteLine();

static string[] GetArrayStringConsole(string inConsolSimvol)
{
    return inConsolSimvol.Split(",");
}

static string[] GetArrayThreeSimvol(string[] array)
{
    int count = 0;

    foreach (string simvol in array)
    {
        if (simvol.Length <= 3)
        {
            count++;
        }
    }

    string[] arrayThreeSimvol = new string[count];

    int index = 0;
    foreach (string simvol in array)
    {
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[index++] = simvol;
        }
    }

    return arrayThreeSimvol;
}

static void Print(string[] array)
{
    foreach (string item in array)
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine();
}