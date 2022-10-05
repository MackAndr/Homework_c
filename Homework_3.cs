// =====Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/* int Palindrome (int number)
{
    if( number > 9999 && number < 100000)
    {
        int n1 = number / 10000;
        int n2 = (number / 1000) % 10;
        int n4 = (number / 10) % 10;
        int n5 = number % 10;
        if (n1 == n5 && n2 == n4)
        {
            Console.WriteLine("Это палиндром!");
        }
        else
        {
            Console.WriteLine("Это не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Данное число не является пятизначным положительным числом");
    }
    return number;
}

Console.WriteLine("Введите положительное пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int numberP = Palindrome(num); */




// =====Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53  


/* Console.WriteLine("Enter x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));

Console.WriteLine($"Расстояние между точками ({x1},{y1},{z1}) и ({x2},{y2},{z2}) = {result:f3}"); */



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int CubNumber (int number)
{
    Console.WriteLine("Таблица кубов:");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} --> {Math.Pow(i,3)}");
    }
    return number;
}

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

int Table = CubNumber (N);
