// // Задача 48: Задайте двумерный массив размера m на n, 
// // каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// // Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5


// Console.Clear();
// Console.WriteLine("Введите число строк: ");
// int line = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столюцов: ");
// int colum = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[line, colum];
// for(int i = 0; i < line; i++)
// { 
// for(int j = 0; j < colum; j++)
// {
//     matrix[i,j] = i + j;
//     Console.Write(" "+matrix[i,j]);
// }
// Console.WriteLine();
// }


// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Console.Clear();
// Console.WriteLine("Введите число строк: ");
// int line = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столюцов: ");
// int colum = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[line, colum];
// for(int i = 0; i < line; i++)
// { 
// for(int j = 0; j < colum; j++)
// {
//     matrix[i,j] = i + j;
//     Console.Write(" "+matrix[i,j]);
// }
// Console.WriteLine();
// }

// // Задача 51: Задайте двумерный массив. Найдите элементы, у 
// // которых оба индекса чётные, и замените эти элементы на их 
// // квадраты.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Сумма элементов главной диагонали: 1+9+2 = 12


// //Данил Зерин

// //Задача 51
            Console.Write("Введите количество строк: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = int.Parse(Console.ReadLine());
            int [,] matrix = new int [m,n];
            int sum = 0;
            Random rand = new Random();

            void FillAndPrintMatrix(int [,] array)
            {
            for (int i = 0; i<m ;i++)
            {
                for (int j = 0; j<n ;j++)
                {
                    matrix [i,j] = rand.Next(1,10);
                    Console.Write(matrix [i,j]+" ");
                }
                Console.WriteLine();
            }
            }

            FillAndPrintMatrix(matrix);

            Console.WriteLine();

            for (int i = 0; i<m ;i++)
            {
                for (int j = 0; j<n ;j++)
                {
                    if (i==j)
                    {
                        sum += matrix [i,j]; 
                    }
                }
            }
            Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

 