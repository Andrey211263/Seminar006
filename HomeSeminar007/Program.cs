
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("47) Задача 47: Задайте двумерный массив размером m строл n столбцов, заполненный случайными вещественными числами.");
        Console.WriteLine("50) Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine("52) Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("Enter number task");

        if (numTask == 0) return;
        else
        {
            if (numTask == 47)
            {
                Matr();
            }
            else
            {

                if (numTask == 50)
                {
                    SearchNumber();
                }
                else
                {
                    if (numTask == 52) ArithmeticMean();
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
        }
    }

}
Start();
// ====Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами. Например:  m = 3, n = 4.
//
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//метод ввод с клавиатуры с конверттацией
int SetNumber(string numberName)
{
    Console.Write($" {numberName} :");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// метод формирования мартрицы из вещественных чисел, два знака после запятой
double[,] Matrix(int m, int n)
{
    double[,] tabl = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tabl[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-100, 100), 2);
            Console.Write($" {tabl[i, j]}");
        }
        Console.WriteLine();
    }
    return tabl;
}

// метод печати матрицы с точностью один знак после запятой

void MatrixPrint(double[,] array)
{
    int line = array.GetLength(0);
    int colum = array.GetLength(1);

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
void Matr()
{
    int line = SetNumber("Введите количество строк");
    int colum = SetNumber("Введите количество столбцов");
    double[,] res = new double[line, colum];
    res = Matrix(line, colum);
    Console.WriteLine();
    MatrixPrint(res);
}

// ====Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

void SearchNumber()
{
    int line = SetNumber("Введите количество строк");
    int colum = SetNumber("Введите количество столбцов");
    double[,] res = new double[line, colum];
    res = Matrix(line, colum);
    int position = SetNumber("Введите поцицию элемента в формате xy(положительное число), где x-строка y-столбец");
    SearchPosition(res, position);
}

void SearchPosition(double[,] arrey, int x)
{
    int line = arrey.GetLength(0);
    int colum = arrey.GetLength(1);
    int m = x / 10;
    int n = x % 10;
    if (m <= line && n <= colum) Console.WriteLine($"искомый элемент [{m}, {n}] {arrey[m, n]}");
    else
    {
        Console.WriteLine($"искомый элемент [{m}, {n}] отсутствует");
    }

}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void ArithmeticMean()
{
    int line = SetNumber("Введите количество строк");
    int colum = SetNumber("Введите количество столбцов");
    int[,] matrix = new int[line, colum];
    matrix = IntMatrix(line, colum);
    Arithmetic(matrix, line, colum);

}

// формируем int матрицу
int[,] IntMatrix(int line, int colum)
{
    int[,] array = new int[line, colum];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    return array;
}

// среднеарифметическое столбцов с выводом на консоль
void Arithmetic(int[,] array, int line, int colum)
{
    double[] sum = new double[colum];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            sum[j] = sum[j] + array[i, j];
        }
    }
    Console.Write("Среднеарифметическое столбцов = ");
    for (int i = 0; i < colum; i++)
    {
        sum[i] = Math.Round(sum[i] / line, 2);
        Console.Write($" {sum[i]}");
    }
    Console.WriteLine();
}