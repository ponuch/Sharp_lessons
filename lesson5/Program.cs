// ***************************************************************************************************************************************
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.                                                 *
// Напишите программу, которая покажет количество чётных чисел в массиве.                                                                *
// ***************************************************************************************************************************************

Console.WriteLine("Input array size");
int size = Int32.Parse(Console.ReadLine());
int[] arr = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++) {
    arr[i] = random.Next(100, 999);
}

PrintArray(arr);

Console.WriteLine(GetEvenNumberCount(arr));

int GetEvenNumberCount(int[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count++;
        }
    }

    return count;
}

// ***************************************************************************************************************************************
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.          *                                                                *
// ***************************************************************************************************************************************

Console.WriteLine("Input array size");
int arr_size = Int32.Parse(Console.ReadLine());
int[] array = new int[arr_size];
Random rnd = new Random();

for (int i = 0; i < arr_size; i++) {
    array[i] = random.Next(-100, 100);
}

PrintArray(array);

Console.WriteLine(GetOddSum(array));

int GetOddSum(int[] arr) {
    int sum = 0;
    for(int i = 1; i < arr.Length; i++) {
        if (i % 2 != 0) {
            sum += arr[i];
        }
    }
    return sum;
}


// ***************************************************************************************************************************************
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.                     *                                                                *
// ***************************************************************************************************************************************

Console.WriteLine("Input array size");
int size_arr = Int32.Parse(Console.ReadLine());
double[] d_array = InputArray(size_arr);
double min = GetMin(d_array);
double max = GetMax(d_array);

Console.WriteLine("Min = {0:0}", min);
Console.WriteLine("Max = {0:0}", max);

Console.WriteLine("Result = {0:0}", max - min);

double GetMin(double[] array) {
    double result = 0.0;
    for(int i = 0; i < array.Length; i++) {
        if (result.CompareTo(array[i]) > 0) {
            result = array[i];
        }
    }

    return result;
}

double GetMax(double[] array) {
    double result = 0.0;
    for(int i = 0; i < array.Length; i++) {
        if (result.CompareTo(array[i]) < 0) {
            result = array[i];
        }
    }

    return result;
}

double[] InputArray(int size) {
    double [] arr = new double[size];
    for(int i = 0; i < size; i++) {
        Console.WriteLine("Input {0:0} element", i);
        arr[i] = Double.Parse(Console.ReadLine());
    }
    return arr;
}




// Print array
void PrintArray(int[] array) {
    for (int i= 0; i < array.Length; i++) {
        Console.Write("{0:0} ", array[i]);
    }
    Console.WriteLine();
}