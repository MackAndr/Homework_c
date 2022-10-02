void Homework7 ()
{
    Console.WriteLine("Нажмите 1 для вызова задачи 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine("Нажмите 2 для вызова задачи 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine("Нажмите 3 для вызова задачи 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine("Нажмите 4 для вызова задачи 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    Console.WriteLine("Нажмите 5 для вызова задачи 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
    switch(n)
    {
    case 1: MassRegulation(); break;
    case 2: MassSummMin(); break;
    case 3: ProductMatrix(); break;
    case 4: MassXYZ(); break;
    case 5: MassSpiral(); break;
    
    default: Console.WriteLine("Неправильно введен указатель"); break;
    }
    
}
Homework7 ();


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void MassRegulation ()
{
    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
    Console.WriteLine("Задан массив:");
    int[,] arrRandom = new int [m,n];
    
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrRandom[i,j] = new Random().Next(1,10);
            Console.Write($"{arrRandom[i,j]} ");
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("Упорядочивание массива по убыванию:");

    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                if (arrRandom[i,j] <= arrRandom[i,k]) continue;
                int temp = arrRandom[i,j];
                arrRandom[i,j] = arrRandom[i,k];
                arrRandom[i,k] = temp;
            }        
        }       
    }
     for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            
            Console.Write($"{arrRandom[i,j]} ");
        }
        Console.WriteLine();
    }
}

//MassRegulation();



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



void MassSummMin ()
{
    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (n == m)
    {
        Console.WriteLine("В условиях задачи сказано, что массив должен быть прямоугольным, но ведь и квадрат это частный случай прямоугольника -_-");
    }
    Console.WriteLine();
    Console.WriteLine("Задан массив:");
    int[,] array = new int [m,n];
    
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
    int summ = 0;
    int[] arr = new int [m];
    Console.WriteLine("Сумма(S) каждой строки:");
    for (int i = 0; i < m; i++)
    {
        summ = 0;
        
        for (int j = 0; j < n; j++)
        {
            summ += array[i,j];
        }
        arr[i] = summ;
        Console.Write($"S[{i}] = {arr[i]}  "); 
    }
    Console.WriteLine();
    
    int count = 0;
    int min = arr[0];
    for (int i = 1; i < m; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            count = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов : {count}");
    
}
// MassSummMin ();


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void ProductMatrix ()
{
    int m = new Random().Next(2,4);
    int n = new Random().Next(2,4);
    int p = new Random().Next(2,4);

    int[,] matrix1 = new int[m,n];
    Console.WriteLine("Матрица A:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix1[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix1[i,j]} ");
        }
        Console.WriteLine();
    }

    int[,] matrix2 = new int[n,p];
    Console.WriteLine("Матрица B:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < p; j++)
        {
            matrix2[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix2[i,j]} ");
        }
        Console.WriteLine();
    }

    int[,] matrix3 = new int[m,p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            int matrixSumm = 0;
            for (int k = 0; k < p; k++)
            {
                matrixSumm += matrix1[i,k] * matrix2[k,j];
            }
            matrix3[i,j] = matrixSumm;
        }
    }
    Console.WriteLine("Матрица C:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            Console.Write($"{matrix3[i,j]} ");
        }
        Console.WriteLine();
    }
}
// ProductMatrix();



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void MassXYZ()
{
    //Задаем массив, состоящий из не более чем 27 элементов (для адекватного вывода в консоле)
    int x = new Random().Next(2, 4);
    int y = new Random().Next(2, 4);
    int z = new Random().Next(2, 4);
    int[,,] array3D = new int[x, y, z];

    
    int[] massDouble = new int[27];
    for (int i = 0; i < 27; i++)
    {
        massDouble[i] = new Random().Next(10, 99);

        if (i != 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (massDouble[i] == massDouble[j])
                {
                    massDouble[i] = new Random().Next(10, 99);
                    j = 0;
                }
            }
        }
    }

    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                array3D[i,j,k] = massDouble[count];
                count++;
            }
        }
    }
    for (int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                Console.Write($"{array3D[i,j,k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
// MassXYZ();




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Так понимаю, здесь массив должен быть не только 4 на 4 как в задании.
void MassSpiral ()
{
    int row = new Random().Next(3, 8);
    int col = row;
    int[,] arraySpiral = new int[row, col];
    int num = 1;
    int m = 0;
    int n = 0;

    while (num <= row * col)
    {
        arraySpiral[m, n] = num;
        num++;

        if (m <= n + 1 && m + n < row - 1) n++;
        else if (m < n && m + n >= row - 1) m++;
        else if (m >= n && m + n > col - 1) n--;   
        else m--;   
    }
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            if (arraySpiral[i,j] < 10)
            {
                Console.Write($"0{arraySpiral[i,j]} ");
            }
            else{Console.Write($"{arraySpiral[i,j]} ");}
        }
        Console.WriteLine();
    }
}
// MassSpiral ();
