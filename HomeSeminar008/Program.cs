
Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("54) Задача 54: Упорядочивание по убыванию элементов каждой строки двумерного массива.");
        Console.WriteLine("56) Задача 56: Поиск строки с с наименьшей суммой элементов.");
        Console.WriteLine("58) Задача 58: Произведение двух матриц.");
        Console.WriteLine("60) Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Выводить массива с добавлением индекса каждого элемента");
        Console.WriteLine("62) Задача 62: апишите программу, которая заполнит спирально массив 4 на 4.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("Enter number task");

        switch (numTask)
        {
            case 0: return; break;
            case 54: IntSort(); break;
            case 56: SearchSum(); break;
            case 58: MatrixProduct(); break;
            case 60: MatrixCub(); break;
            case 62: MetodUlitka(); break;
            default: Console.WriteLine("error"); break;
        }

    }

}

int SetNumber(string numberName)
{
    Console.Write($" {numberName}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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


int[,]  IntMatrixFix(int line, int colum)
{
    // int line = 3;
    // int colum = 3;
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
// метод сортировки на убывание - пузырек
int[,] SortMin(int[,] array)
{
    int line = array.GetLength(0);
    int colum = array.GetLength(1);
    int temp;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            for (int m = 1; m < colum - j; m++)
            {

                if (array[i, m - 1] < array[i, m])
                {
                    temp = array[i, m - 1];
                    array[i, m - 1] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
    return array;
}

// вывод на печать матрицу
void PrintArray(int[,] array)
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
// сумма строк, возвращает одномерный массив с сумами строк
int[] SumLine(int[,] array)
{
    int line = array.GetLength(0);
    int colum = array.GetLength(1);
    int[] sum = new int[line];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void IntSort()
{
    int[,] Array = IntMatrix();
    int[,] mass = SortMin(Array);
    Console.WriteLine();
    PrintArray(mass);
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void SearchSum()
{
    int[,] NewArray = IntMatrix();
    int[] summ = SumLine(NewArray);
    int size = summ.GetLength(0);
    Console.WriteLine($"сумма строк от 0-ой до {size - 1}-ой) массива = {String.Join(" ", summ)}");
    int min = summ[0];
    int index = 0;
    for (int i = 1; i < size; i++)
    {
        if (min > summ[i])
        {
            min = summ[i];
            index = i;
        }
    }
    Console.WriteLine($"Минимальная строкя {index}, сумма = {min}");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы: c[i,j] = a[i,1]*b[1,j]+a[i,2]*b[2,j]+a[i,3]*b[3,j]...
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MatrixProduct()
{
    int line1 = SetNumber("Введите количество строк матрицы А ");
    int column1 = SetNumber("Введите количество столбцов матрицы А");
    int column2 = SetNumber("Введите количество столбцов матрицы В");
    int[,] Array1 = IntMatrixFix(line1, column1);
       Console.WriteLine();
    int[,] Array2 = IntMatrixFix(column1, column2);
        int[,] newArray = new int[line1, column2];
    for (int i = 0; i < line1; i++)
    {
        int j = 0; int m = 0;
        int colum = Array1.GetLength(1);
        for (int n = 0; n < column2; n++)
        {
            //newArray[i, n] = Array1[i, j] * Array2[m, n] + Array1[i, j + 1] * Array2[m + 1, n] + Array1[i, j + 2] * Array2[m + 2, n];
            for(int k =0; k < colum; k++ )
            {
            newArray[i, n] = newArray[i, n] + Array1[i, j + k] * Array2[m+k, n];
            }


        }
    }


    Console.WriteLine();
    Console.WriteLine($"произведение матриц ");
    PrintArray(newArray);
}
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента. 
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void MatrixCub()
{
    int line = SetNumber("Введите количество строк");
    int column = SetNumber("Введите количество столбцов");
    int height = SetNumber("Введите высоту");
    int[,,] Cub = new int[line, column, height];
    int m = 0;
    int[] bufer = new int[line * column * height];

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int h = 0; h < height; h++)
            {
                Cub[i, j, h] = new Random().Next(10, 100);
                Console.Write($" {Cub[i, j, h]} ({i},{j},{h})");
                bufer[m] = Cub[i, j, h];
                //проверка заполненого массива на совпадение
                for (int k = m; k > 0; k--)
                {
                    if (Cub[i, j, h] == bufer[k - 1])
                    {
                        Cub[i, j, h] = new Random().Next(10, 99);
                        bufer[m] = Cub[i, j, h];
                        // запустим повторную проверку после перезаписи повторяющегося элемента
                        for (int l = m; l > 0; l--)
                        {
                            if (Cub[i, j, h] == bufer[l - 1])
                            {
                                Cub[i, j, h] = new Random().Next(10, 99);
                                bufer[m] = Cub[i, j, h];
                               // Console.Write($"Перезапись {Cub[i, j, h]} ({i},{j},{h})");
                                break;
                            }

                        }
                        // конец повторной проверки после перезаписи повторяющегося элемента                       
                        break;
                    }

                }
                m++;
                // Console.WriteLine($"Bufer = {String.Join(" ", bufer)}");
            }

            Console.WriteLine();

        }
    }
    Console.WriteLine();

}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] ulitka(int[,] array, int k, int line, int column, int direction)
// {
//     switch (direction)
//     {
//         case 00: leftR(); break;             //направление движения слева на право
//         case 01: down(); break;          //направление движения с верху вниз
//         case 02: reach(); break;        //направление движения  с право на лево
//         case 03: up(); break;    //направление движения с низу вверх
//         //case 60: MatrixCub(); break;
//         // default: Console.WriteLine("error"); break;
//     }
// //направление движения слева на право
//int[,] leftR()
//if (line == 0 && column == 0) 
void MetodUlitka()
{
    int line = SetNumber("Введите количество строк ");
    int k = line - 1;   //глубина заполнения строки
    int l;              //глубина заполнения столбца
    int count = 1;      //пишем в матрицу
    int pass = 2 * line;//кол-во проходов 
    int i = 0; int j = 0;
    int[,] MatrixUl = new int[line, line];
    while (pass > 0)
    {
        //рисуем строку вправо
        l = k;
        for (; l > 0; l--)
        {
            MatrixUl[i, j] = count;
            count++;
            j++;

        }
        pass--;

        //рисуем  строку вниз
        l = k;
        for (; l > 0; l--)
        {
            MatrixUl[i, j] = count;
            count++;
            i++;
        }
        pass--;

        //рисуем  строку влево
        l = k;
        for (; l > 0; l--)
        {
            MatrixUl[i, j] = count;
            count++;
            j--;
        }
        pass--;

        //рисуем  строку вверх
        l = k;

        for (; l > 0; l--)
        {
            MatrixUl[i, j] = count;
            count++;
            i--;
        }
        k -= 2;
        i++;
        j++;
        pass--;

    }
    //Console.WriteLine($"index i = {i}, j = {j}, k = {k}, pass ={pass}");
    if (line % 2 != 0) MatrixUl[i-1, j-1] = count; // проверяем четниая матрица или нет
    PrintArray(MatrixUl);
}

