// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку 
// массива.

// метод формирования матрицы со случайными значениями столбцов и строк в заданном диапазоне
int[,] IntMatrix()
{
    int line = new Random().Next(3, 6);
    int colum = new Random().Next(3, 6);
    int[,] array = new int[line, colum];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    return array;
}

// меняем местами последнюю и первую строки
int[,] ReverArr(int[,] MyArr)
{
    int line = MyArr.GetLength(0), colum = MyArr.GetLength(1);
    int temp = 0;
    for (int i = 0; i < colum; i++)
    {
        temp = MyArr[0, i];
        MyArr[0, i] = MyArr[line - 1, i];
        MyArr[line - 1, i] = temp;

    }
    return MyArr;
}

// вывод на печать матрицу
void PrintArrey(int[,] array)
{
    int line = array.GetLength(0);
    int colum = array.GetLength(1);

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

// int[,] Arrey = IntMatrix();
// Console.WriteLine();
// int[,] MyArrey = ReverArr(Arrey);
// PrintArrey(MyArrey);

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя.

// метод отражение матрицы по диагонали 
int[,] ReverArrey(int[,] MyArr)
{
    int Rows = MyArr.GetLength(0), Cols = MyArr.GetLength(1);

    int temp = 0;
    for (int i = 0; i < Rows; i++)
    {
        for (int j = i; j < Cols; j++)
        {
            temp = MyArr[j, i];
            MyArr[j, i] = MyArr[i, j];
            MyArr[i, j] = temp;
        }
    }
    return MyArr;
}

// int[,] Arrey = IntMatrix();
// Console.WriteLine();
// if (Arrey.GetLength(0) == Arrey.GetLength(1))
// {
//     int[,] MyArr = ReverArrey(Arrey);
//     PrintArrey(MyArr);
// }
// else
// {
// Console.WriteLine("До свидания! Замена строк на столбцы не возможна");
// }

// //  Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент 
// входных данных.


// метод составления частотного словаря. На выходу 2 строки: 1-я сами элементы, 2-я количество повторений
int[,] SortSlovar(int[,] Arrey)
{
    int line = Arrey.GetLength(0);
    int colum = Arrey.GetLength(1);
    int[,] Slovar = new int[2, line * colum];

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            for (int c = 0; c < line * colum; c++)
            {
                if (Slovar[0, c] == Arrey[i, j])
                {
                    if (Slovar[1, c] == 0)
                    {
                        Slovar[0, c] = Arrey[i, j];
                    }
                    Slovar[1, c] += 1;
                    break;
                }
                else
                {
                    if (Slovar[1, c] == 0)
                    {
                        Slovar[0, c] = Arrey[i, j];
                        Slovar[1, c] += 1;
                        break;
                    }
                }

            }

        }
    }
    return Slovar;
}

// int[,] Arrey = IntMatrix();
// Console.WriteLine();
// PrintArrey(SortSlovar(Arrey));


// Задача 59: Задайтедвумерный массив из целых чисел. Напишите 
// программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.

// поиск индексов минимального значения массива
int[] MinMass(int[,] Array)
{
    int line = Array.GetLength(0);
    int colum = Array.GetLength(1);
    int min = Array[0, 0];
    int lineMin = 0;
    int columMin = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
            if (min > Array[i, j])
            {
                min = Array[i, j]; lineMin = i; columMin = j;
            }
    }
    int[] result = new int[2];
    result[0] = lineMin;
    result[1] = columMin;
    Console.WriteLine($"Min элемент массива [{lineMin}],[{columMin}] = {min}");
    return (result);

}



int[,] Mass = IntMatrix();
int Line = Mass.GetLength(0);
int Colum = Mass.GetLength(1);
Console.WriteLine();
int[] res = MinMass(Mass);
int newLine = Colum - 1; int newColum = Line - 1;
int minLine = res[0]; int minColum = res[1];

int[,] newMass = new int[newLine, newColum];


int m = 0;
int n = 0;
for (int i = 0; i < newLine; i++)
{
    if (n == minColum) n += 1; // исключаем минимальный столбец
    for (int j = 0; j < newColum; j++)
    {
        if (m == minLine) m += 1; // исключаум минимальную строку
        newMass[i, j] = Mass[m, n]; //в строку нового массива пишем старый столбец
        m++;
    }
    m = 0;
    n++;
}
Console.WriteLine();
PrintArrey(newMass);

