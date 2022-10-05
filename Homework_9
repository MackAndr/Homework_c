void Homework9 ()
{
    Console.WriteLine("Нажмите 1 для вызова задачи 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
    Console.WriteLine("Нажмите 2 для вызова задачи 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("Нажмите 3 для вызова задачи 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
    switch(n)
    {
    case 1: NaturalNumbers(); break;
    case 2: NaturalElemetSum(); break;
    case 3: Akkerman(); break;
    
    default: Console.WriteLine("Неправильно введен указатель"); break;
    }
    
}
Homework9 ();

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


void NaturalNumbers()
{
    string RecursionNaturalNumbers(int M, int N)
    {
        if (M < N) return $"{M}, " + RecursionNaturalNumbers(M + 1, N); // усложнил немного код для более красивого вывода результата
        else { if (M == N) return $"{M}"; else return String.Empty; }

    }
    int m = new Random().Next(1, 6);
    int n = new Random().Next(5, 10);
    Console.Write($"M = {m}; N = {n} --> [{RecursionNaturalNumbers(m, n)}]");
}



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void NaturalElemetSum()
{
    int RecursionNaturalSumNum(int M, int N)
    {
        if (M == N) return M;
        else return M + RecursionNaturalSumNum(M + 1, N);
    }
    int m = new Random().Next(1, 6);
    int n = new Random().Next(5, 10);
    Console.Write($"M = {m}; N = {n} --> {RecursionNaturalSumNum(m, n)}");
}




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


void Akkerman()
{
    int RecursionAkkerman(int m, int n)
    {
        if (m == 0) { n++; return n; }
        else
        {
            if (n == 0 && m != 0) { return RecursionAkkerman(m - 1, 1);}
            else return RecursionAkkerman(m - 1, RecursionAkkerman(m, n - 1));
        }
    }
    int a = new Random().Next(0, 4);
    int b = new Random().Next(0, 12);
    Console.WriteLine($"m = {a}, n = {b} --> {RecursionAkkerman(a, b)}");
}
