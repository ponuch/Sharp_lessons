// ***************************************************************************************************************************************
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.                             *
// ***************************************************************************************************************************************

Console.WriteLine("Input array size");
int size = Int32.Parse(Console.ReadLine());

int[] arr = InputArray(size);
Console.WriteLine("Result = {0:0}", GetPositiveNumbersCount(arr));


int GetPositiveNumbersCount(int[] arr) {
    int result = 0;
    for(int i = 0; i < arr.Length; i++) {
        if (arr[i] > 0) {
            result++;
        }
    }

    return result;
}

int[] InputArray(int size) {
    int [] arr = new int[size];
    for(int i = 0; i < size; i++) {
        Console.WriteLine("Input {0:0} element", i);
        arr[i] = Int32.Parse(Console.ReadLine());
    }
    return arr;
} 

// ***************************************************************************************************************************************
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,                     *
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.                                                                     *
// ***************************************************************************************************************************************
Console.WriteLine("Input b1 for point 1");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Input k1 for point 1");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Input b2 for point 1");
double b2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Input k2 for point 1");
double k2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Point of intersection = {0:0}", CalculateIntersection(b1, k1, b2, k2));


Point CalculateIntersection(double b1, double k1, double b2, double k2) {
    double x = 0.0;
    double y = 0.0;
    if ((k1 - k2).CompareTo(0) != 0) {
        x = (b2 - b1) / (k1 - k2);
    }
    else {
        throw new Exception("Lines are parallel");
    }

    y = k2 * x + b2;
    return new Point(x, y);
}

// Print array
void PrintArray(int[] array) {
    for (int i= 0; i < array.Length; i++) {
        Console.Write("{0:0} ", array[i]);
    }
    Console.WriteLine();
}

public struct Point
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}