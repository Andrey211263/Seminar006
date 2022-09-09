// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
long[] Input(int num)
{
long[] InputArray = new long[num];
Console.WriteLine($"num = {num}");

for(int i = 0; i < num; i++)
//int i = 0;
//while(i < num)
{
Console.Write($"- введите {i+1} элемент: ");    
InputArray[i] = int.Parse(Console.ReadLine());
Console.WriteLine($"-  {i} -> {InputArray[i]}");
}
return InputArray;
}
void PositivNumber(long[] Array)
{
    int length = Array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(Array[i] > 0)  
        {
        count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел равно: {count}");
}

Console.Clear();
Console.Write("Введите количество элементов :");
int count = Convert.ToInt32(Console.ReadLine());

long[] newArray = Input(count);

Console.WriteLine(String.Join(", ", newArray ));
PositivNumber(newArray);



// //Задача 51
//             Console.Write("Введите количество строк: ");
//             int m = int.Parse(Console.ReadLine());
//             Console.Write("Введите количество столбцов: ");
//             int n = int.Parse(Console.ReadLine());
//             int [,] matrix = new int [m,n];
//             int sum = 0;
//             Random rand = new Random();

//             void FillAndPrintMatrix(int [,] array)
//             {
//             for (int i = 0; i<m ;i++)
//             {
//                 for (int j = 0; j<n ;j++)
//                 {
//                     matrix [i,j] = rand.Next(1,10);
//                     Console.Write(matrix [i,j]+" ");
//                 }
//                 Console.WriteLine();
//             }
//             }

//             FillAndPrintMatrix(matrix);

//             Console.WriteLine();

//             for (int i = 0; i<m ;i++)
//             {
//                 for (int j = 0; j<n ;j++)
//                 {
//                     if (i==j)
//                     {
//                         sum += matrix [i,j]; 
//                     }
//                 }
//             }
//             Console.WriteLine($"Сумма элементов главной диагонали = {sum}");