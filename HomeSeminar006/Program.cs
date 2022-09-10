void Start()
 {
     while (true)
     {
         Console.ReadLine();
         Console.Clear();
         Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
         Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1*x + b1; y = k2*x + b2");
         Console.WriteLine("0) End");
       
         int numTask = SetNumber("task");
       
         switch (numTask)
         {
             case 0: return; break;
             case 41: PlusCount(); break;
             case 43: IntersectionPoint(); break;
             default: Console.WriteLine("error"); break;
         }
    
     }

 }

 int SetNumber(string numberName)
 {
     Console.Write($"Enter Number {numberName}:");
     int num = Convert.ToInt32(Console.ReadLine());
     return num;
 }

Start();
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Формируем массив из чисел вводимых с клавиатуры, num размер массива
 double[] Input(int num)
 {
 double[] InputArray = new double[num];
 Console.WriteLine($"num = {num}");

 for(int i = 0; i < num; i++)
  {
 Console.Write($"- введите {i+1} элемент: ");    
 InputArray[i] = double.Parse(Console.ReadLine());
 Console.WriteLine($"-  {i} -> {InputArray[i]}");
 }
 return InputArray;
 }
 
 //Подсчет положительных чисел в массиве
 void PositivNumber(double[] Array)
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
void PlusCount()
{
 Console.Clear();
 Console.Write("Введите количество элементов :");
 int count = Convert.ToInt32(Console.ReadLine());

 double[] newArray = Input(count);

 Console.WriteLine($"наш массив -> {String.Join(" ", newArray )}");
 PositivNumber(newArray);
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint()
{
 Console.Clear();
 Console.WriteLine("Имеем уравнение: k1*x +b1");
 Console.Write("Введите K1 :");
 double k1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите b1 :");
 double b1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Имеем уравнение: k2*x +b2");
 Console.Write("Введите K2 :");
 double k2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите b2 :");
 double b2 = Convert.ToInt32(Console.ReadLine());

 if (k1 == k2)     
 {
     Console.WriteLine("Прямые паралельны, решения нет");
 }
 else
 {
 double x = (b2-b1)/(k1-k2);
 double y = k1*x + b1;
 Console.WriteLine($"Точка пересечения 2-х прямых: х = {x},  у = {y}");
 }
}