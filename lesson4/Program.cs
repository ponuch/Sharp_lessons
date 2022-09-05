// ***************************************************************************************************************************************
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.                     *
// ***************************************************************************************************************************************

Console.WriteLine("Input number");
int number = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input pow");
int pow = Int32.Parse(Console.ReadLine());
Console.WriteLine("Result = {0:0}", PowNumber(number, pow));


int PowNumber(int number, int pow) {
    int result = 1;
    for (int i = 1; i<= pow; i++) {
        result *= number;
    }
    return result;
}

// ***************************************************************************************************************************************
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.                                           *
// ***************************************************************************************************************************************

Console.WriteLine("Input number");
int num = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sum of digits = {0:0}", GetSumDigitsOfNumber(num));

int GetSumDigitsOfNumber(int num) {
    int[] arr = ParseNumber(num);
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        sum += arr[i];
    }
    return sum;
}

int[] ParseNumber(int number) {
    var list = new List<int>();
    while (number > 0) {
        var digit = number % 10;
        number /= 10;
        list.Add(digit);
    }
    list.Reverse();
    return list.ToArray<int>();
}


// ***************************************************************************************************************************************
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.                                            *
// ***************************************************************************************************************************************

Console.WriteLine("Input array size");
int size = Int32.Parse(Console.ReadLine());
PrintArray(InputArray(size));
Console.WriteLine("The end.");


int[] InputArray(int size) {
    int [] arr = new int[size];
    for(int i = 0; i < size; i++) {
        Console.WriteLine("Input {0:0} element", i);
        arr[i] = Int32.Parse(Console.ReadLine());
    }
    return arr;
}


void PrintArray(int[] array) {
    for (int i= 0; i < array.Length; i++) {
        Console.Write("{0:0} ", array[i]);
    }
}
