// *********************************************************************************************************************
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.*
// *********************************************************************************************************************

Console.WriteLine("Input M");
int m1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input N");
int n1 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

if (m1 > n1) {
    Console.WriteLine("N should be bigger than M");
    return;
}

PrintNumbers(m1, n1);

void PrintNumbers(int m, int n) {
    for (int i = m; i <= n; i++) {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

// *********************************************************************************************************************
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке      *
// *********************************************************************************************************************

Console.WriteLine("Input M");
int m2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input N");
int n2 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

if (m2 > n2) {
    Console.WriteLine("N should be bigger than M");
    return;
}

Console.WriteLine($"Sum = {GetSum(m2, n2)}");

int GetSum(int m, int n) {
    int result = 0;

    for(int i = m; i <= n; i++) {
        result += i;
    }

    return result;
}

// *********************************************************************************************************************
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*
// *********************************************************************************************************************

Console.WriteLine("Input M");
uint m3 = UInt32.Parse(Console.ReadLine());
Console.WriteLine("Input N");
uint n3 = UInt32.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"A = {A(n3, m3)}");


uint A(uint n, uint m) {
    if (n == 0) {
        return m + 1;
    }
    else if (n != 0 && m ==0) {
        return A(n - 1, 1);
    }
    else {
        return A(n - 1, A(n, m -1));
    }
}