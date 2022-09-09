//====== расмотрение домашнего задания =======
// Start();


// void Start()
// {
//     while (true)
//     {
//         Console.ReadLine();
//         Console.Clear();
//         Console.WriteLine("25) Задача 25: Напишите цикл, который принимает на вход два числа и возводит число А в степень В");
//         Console.WriteLine("27) Задача 27: Напишите приграмму, которая принимает на вход число и выдает сумму цифр в числе");
//         Console.WriteLine("29) Задача 29: Напишите программу, которая задает массив из введенного числа и выводит их на экран");
//         Console.WriteLine("0) End");
        
//         int numTask = SetNumber("task");
        
//         switch (numTask)
//         {
//             case 0: return; break;
//             case 25: MyPow(); break;
//             case 27: SumNumber(); break;
//             case 29: ViewArray(); break;
//             default: Console.WriteLine("error"); break;
//         }
    
//     }

// }

 int SetNumber(string numberName)
 {
     Console.Write($"Enter Number {numberName}:");
     int num = Convert.ToInt32(Console.ReadLine());
     return num;
 }

// //Напишите цикл, который принимает на вход два числа и возводит число А в степень 
// void MyPow()
// {
//     Console.Clear();
//     int num = SetNumber("");
//     int degree = SetNumber("degree of");
//     Console.WriteLine($"{num} в степень {degree} = {Pow(num, degree)}");
// }

// int Pow(int num, int rank)
// {
//     if(rank == 0) return 1;
//     else if(rank == 1) return num;
    
//     int result = num;

//     for (int i = 2; i <= rank; i++)
//     {
//         result *=num; // result = result * num;
//     }
//     return result;
// }

// // Напишите приграмму, которая принимает на вход число и выдает сумму цифр в числе
// void SumNumber()
// {
//     Console.Clear();
//     int num = SetNumber("N");
//     Console.WriteLine($"сумма цифр  = {GetSumNums(num)}");
          
// }

// int GetSumNums(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 10;
//         num = num / 10;
//     }
//     return result;
// }


// //Напишите программу, которая задает массив из введенного числа и выводит их на экран
// void ViewArray()
// {
//     Console.Clear();
//     int size = SetNumber("size");
//     int minValue = SetNumber("minvalue");
//     int maxValue = SetNumber("maxvalue");
//     int[] array = GetRandomArray(size, minValue, maxValue);
//     Console.WriteLine($"[{String.Join(",", array)}]");
// }


// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//        result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }


//======= Seminar 006 =======
// // Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 2 -> 10

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int temp = number;
// int value = number;
// int count = 0;
// while(number != 0)
// {
// number /=2;
// count++;
// }

// int[] Bitarray = new int[count];

// while(temp != 0)
// {
// Bitarray[count-1] = temp % 2;
// temp /=2;
// count--;
// }
// Console.WriteLine();
// Console.WriteLine(String.Join("",Bitarray));

// Console.WriteLine(Convert.ToString(value, 2));

// ==== Задача 44
// Не используя рекурсию, выведи первые N чисел Фибоначи. Первые два чмсла 0 и 1
// Если N = 5 -> 0 1 2 3 и т.д.

Console.Clear();
int number =  SetNumber(" "); // вызываю метод SetNumber
Fibanachi(number);
void Fibanachi (int n)
{
int[] arrayFibanachi = new int[n];
arrayFibanachi[0] = 0;
arrayFibanachi[1] = 1;
for(int index = 2; index < n; index++)
{
arrayFibanachi[index] = arrayFibanachi[index - 1] + arrayFibanachi[index - 2];
}
Console.WriteLine(String.Join(" ",arrayFibanachi));
}