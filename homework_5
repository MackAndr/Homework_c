//В задании не было чётко указано как задавать длину массива, поэтому некоторые задачи делал с вводом длины массива пользователем, некоторые - с рандомным заданием длины массива
void Homework5 ()
{
    Console.WriteLine("Нажмите 1 для вызова задачи 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("Нажмите 2 для вызова задачи 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("Нажмите 3 для вызова задачи 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
    Console.WriteLine("Нажмите 4 для вызова задачи 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    int n = Convert.ToInt32(Console.ReadLine());
    
    switch(n)
    {
    case 1: PrintCountEvenNumbers(); break;
    case 2: SummElementsUnevenPositions (); break;
    case 3: ProductDoubleNumbers(); break;
    case 4: differenceMaxMin (); break;
    default: Console.WriteLine("Неправильно введен указатель"); break;
    }
    
}
Homework5 ();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void PrintCountEvenNumbers ()
{
    Console.WriteLine("Введите длину массива");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [count];
    int evenNumber = 0;

    for (int i = 0; i < count; i++)
    {
    array[i] = new Random().Next(100, 1000);
    
    if(array[i] % 2 == 0)
    {
        evenNumber++;
    }  
    }

    Console.WriteLine($"В массиве [{(String.Join(", ", array))}] количество четных чисел: ({evenNumber})");   
}

// PrintCountEvenNumbers();



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void SummElementsUnevenPositions ()
{
    Console.WriteLine("Введите длину массива");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [count];
    int Summ = 0;

    for (int i = 0; i < count; i++)
    {
    array[i] = new Random().Next(1, 100);
    
    if(i % 2 != 0)
    {
        Summ += array[i];
    }  
    }

    Console.WriteLine($"Сумма элементов на нечётных позициях в массиве [{(String.Join(", ", array))}] будет: ({Summ})");   
}

// SummElementsUnevenPositions ();



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void ProductDoubleNumbers()
{
    int count = new Random().Next(2, 10);
    int[] array = new int[count];
    int half = count / 2;
    
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

    int[] product = new int[half];

    
    if (count % 2 == 0)
    {
        for (int i = 0; i < half; i++)
    {
        product[i] = array[i] * array[count-1];
        count--;
    }
    Console.WriteLine($"Произведение пар чисел в массиве [{String.Join(", ", array)}] будет: [{String.Join(", ", product)}]");
    }
    else
    {
        for (int i = 0; i < half; i++)
    {
        product[i] = array[i] * array[count-1];
        count--;
    }
    Console.WriteLine($"Произведение пар чисел в массиве [{String.Join(", ", array)}] будет: [{String.Join(", ", product)}, {array[half]}]");
    }
        
}

// ProductDoubleNumbers();



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void differenceMaxMin ()
{
    int count = new Random().Next(5, 15);
    double[] array = new double[count];
    
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-99, 100));
    }

    double min = array[0];
    double max = array[0];
    

    for (int i = 0; i < count; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }

 
    
    Console.WriteLine($"разность между максимальным [{max}] и минимальным [{min}] элементами массива [{String.Join(", ", array)}] будет: ({max - min})");
    // Console.WriteLine($"{min}, {max}");
}

// differenceMaxMin ();
