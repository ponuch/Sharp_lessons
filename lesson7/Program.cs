// *********************************************************************************************************************
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.                     *
// *********************************************************************************************************************

Console.WriteLine("Input m of array dimention");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine();

double[,] arr = new double[m, n];
FillArray(arr);
PrintArray(arr);



void FillArray(double[,] arr) {
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = (double)random.Next(-100, 100) / 10;
        }
    }
}

void PrintArray(double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            Console.Write("{0:G} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}


// *********************************************************************************************************************
// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы     *
// этого элемента или же указание, что такого элемента нет.                                                            *
// *********************************************************************************************************************

Console.WriteLine("Input m of array dimention");
int firstDim = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int secondDim = Int32.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[firstDim, secondDim];
FillIntArray(array);
PrintIntArray(array);

Console.WriteLine("Input number for finding");
int number = Int32.Parse(Console.ReadLine());

var coords = FindNumberCoords(array, number);

if (coords.Count == 0) {
    Console.WriteLine("Element not found");
}
else {
    foreach(var coord in coords) {
        Console.WriteLine(coord);
    }
}


List<Coord> FindNumberCoords(int[,] arr, int num) {
    var result = new List<Coord>();

    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            if (arr[i,j] == num) {
                result.Add(new Coord(i, j));
            }
        }
    }

    return result;
}


// *********************************************************************************************************************
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.      *
// *********************************************************************************************************************

Console.WriteLine("Input m of array dimention");
int firstDim2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int secondDim2 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array2 = new int[firstDim2, secondDim2];
FillIntArray(array2);
PrintIntArray(array2);
Avg(array2);

void Avg(int[,] arr) {
     for (int i = 0; i < arr.GetLength(1); i++) {
        double sum = 0;
        for(int j = 0; j < arr.GetLength(0); j++) {
            sum += arr[j, i];
        }
        Console.WriteLine($"Average for column {i} = {Math.Round(sum / arr.GetLength(1), 1)}");
    }
}



void FillIntArray(int[,] arr) {
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = random.Next(-10, 10);
        }
    }
}

void PrintIntArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            Console.Write("{0:G} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}


public struct Coord
{
    public Coord(int x, int y)
    {
        X = x;
        Y = y;
    } 

    public int X { get; }
    public int Y { get; }

    public override string ToString() => $"({X}, {Y})";
}