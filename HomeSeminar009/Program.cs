Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("64) Задача 64: Выввод натуральных числа в промежутке от M до N.");
        Console.WriteLine("66) Задача 66: Поиск суммы натуральных элементов в промежутке от M до N.");
        Console.WriteLine("68) Задача 68: Вычисления функции Аккермана с помощью рекурсии.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("Enter number task");

        switch (numTask)
        {
            case 0: return; break;
            case 64: NaturalSeries(); break;
            case 66: SumNatural(); break;
                // case 68: MatrixProduct(); break;
                // default: Console.WriteLine("error"); break;
        }

    }

}

int SetNumber(string numberName)
{
    Console.Write($" {numberName}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


void NaturalSeries()
{
    int numberM = SetNumber("Введите число M ");
    int numberN = SetNumber("Введите число N ");
    int OneNumber = 0;
    int length = 0;

    if (numberM > numberN)
    {
        length = numberM - numberN + 1;
        OneNumber = numberN;
    }

    else
    {
        length = numberN - numberM + 1;
        OneNumber = numberM;
    }
    int[] array = new int[length];
    array[0] = OneNumber;

    for (int i = 1; i < length; i++)
    {
        //Console.Write($"{i} -> {array[i-1]}");
        array[i] = array[i - 1] + 1;
    }
    Console.WriteLine();
    Console.WriteLine($"Получаем натуральный ряд от {numberM} до {numberN}:  {String.Join(" ", array)}");
}
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumNatural()
{
    {
        int numberM = SetNumber("Введите число M ");
        int numberN = SetNumber("Введите число N ");
        int OneNumber = 0;
        int EndNumber = 0;


        if (numberM > numberN)
        {
            OneNumber = numberN;
            EndNumber = numberM;
        }

        else
        {
            OneNumber = numberM;
            EndNumber = numberN;
        }
        int count = EndNumber - OneNumber;
        int SumNatural = OneNumber;

        for (int i = 0; i < count; i ++)
        {
            //Console.Write($"{i} -> {OneNumber}, {SumNatural}: ");
            OneNumber +=1;
            SumNatural = SumNatural + OneNumber;
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма натуральных чисел = {SumNatural}");
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29