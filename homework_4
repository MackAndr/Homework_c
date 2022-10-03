// =====Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void intro ()
// {
//     Console.WriteLine("Введите число и степень, в которую его требуется возвести");
//     ToPower (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// }
// double ToPower (int number, int degree)
// {
//     int result = 1;
//     for (int i = 1; i <= degree; i++)
//     {
//         result *= number;
//     }
//     Console.WriteLine($"{number} в степени {degree} равно {result}");
    
//     return result;
// }

// intro();



// =====Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int SumN (int number)
// {
//     int number0 = number;
//     number = Math.Abs(number);
//     int count = 0;
//     int Sum = 0;
    
//     if (number <= 10)
//     {
//         Console.WriteLine($"Сумма цифр в числе {number} равна {number}");
//     }
//     else
//     {
//        while (number > 10)
//         {
//             count = number % 10;
//             Sum += count;
//             number /= 10;
//         }
//         Sum = Sum + number;
//         Console.WriteLine($"Сумма цифр в числе {number0} равна {Sum}");
//     }

//     return Sum;
// }

// Console.WriteLine("Введите число");

// SumN(Convert.ToInt32(Console.ReadLine()));




// =====Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение .
// надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]



int Go (int count, int b, int c)
{
    Console.WriteLine("Введите количество элементов массива");
    count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[count];

    if (count >= 2)
    {
        Console.WriteLine("Введите значение минимального и максимального элементов массива");
        ChooseArr(array, b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine())); 
        if (b > c)
        {
        Console.WriteLine(" ");
        }
        else
        {
            PrintArray(array);
        }
    }
    else
    {
        Console.WriteLine("Неправильно задан массив - массив должен содержать минимум два элемента");
    }    
    return count;
}


void PrintArray (int[] arr)
{
    int count = arr.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{arr[pos]} ");
        pos++;
    }
}


void ChooseArr (int[] randomArr, int min, int max)
{
    int length = randomArr.Length;
    int index = 0;
    
    if (min > max)
    {
        Console.WriteLine("Неправильно заданы параметры минимального и максимального элемента");
    }
    else
    {
    while (index < length)
    {
        randomArr[index] = new Random().Next(min, max);
        index++;
    }
    }
}

int a1 = 0;
int a2 = 0;
int a3 = 0;

Go(a1, a2, a3);
