void Homework6 ()
{
    Console.WriteLine("Нажмите 1 для вызова задачи 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("Нажмите 2 для вызова задачи 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
    switch(n)
    {
    case 1: positiveNumbers(); break;
    case 2: FindPoint (); break;
    
    default: Console.WriteLine("Неправильно введен указатель"); break;
    }
    
}
Homework6 ();



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void positiveNumbers ()
{
    Console.Write("Введите числа через пробел: ");
    string str = Console.ReadLine();
    var strArr = str.Split(" ");

    int[] array = Array.ConvertAll(strArr, int.Parse);
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел: {count}");
}

// positiveNumbers ();



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void FindPoint ()
{
    Console.WriteLine("Введите k1");
    double k1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите k2");
    double k2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите b1");
    double b1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите b2");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;

    Console.WriteLine($"точка пересечения имеет координаты x = {x}, y = {y}");
}

//FindPoint();
