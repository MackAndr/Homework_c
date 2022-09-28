void Homework7 ()
{
    Console.WriteLine("Нажмите 1 для вызова задачи 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    Console.WriteLine("Нажмите 2 для вызова задачи 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine("Нажмите 3 для вызова задачи 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
    switch(n)
    {
    case 1: Mass47(); break;
    case 2: FindEl(); break;
    case 3: SaMass(); break;
    
    default: Console.WriteLine("Неправильно введен указатель"); break;
    }
    
}
Homework7 ();



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Mass47 ()
{
    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] arrDouble = new double [m,n];
    
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrDouble[i,j] = rand.NextDouble() * 10;
            Console.Write($"{arrDouble[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}

// Mass47();



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void FindEl ()
{
    Console.WriteLine("Введите номер строки искомого элемента");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента");
    int n = Convert.ToInt32(Console.ReadLine());

    int m1 = new Random().Next(3,7);
    int n1 = new Random().Next(3,7);
    
    int [,] array = new int [m1,n1];
    Console.WriteLine("Заданный массив:");
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            array[i,j] = new Random().Next(1, 10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    if (m <= m1 && n <= n1)
    {
        Console.WriteLine($"элемент массива [{m},{n}] --> {array[m,n]}");
    }
    else
    {
        Console.WriteLine($"Элемента с позицией [{m},{n}] нет в заданном массиве");
    }
}
// FindEl();



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void SaMass ()
{
    int m = new Random().Next(3,6);
    int n = new Random().Next(3,6);
    
    int[,] array = new int[m, n];
    double[] res = new double[n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1, 10);
            Console.Write($"{array[i,j]}    ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            res[j] += array[i,j];
        }
        Console.Write($"{res[j]/m:f1}  ");
    }

}

// SaMass ();
