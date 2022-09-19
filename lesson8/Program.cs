// *********************************************************************************************************************
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки      *
// двумерного массива.                                                                                                 *
// *********************************************************************************************************************

Console.WriteLine("Input m of array dimention");
int firstDim1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int secondDim1 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array1 = new int[firstDim1, secondDim1];
FillIntArray(array1);
PrintIntArray(array1);
SortLinesOfArray(array1);
PrintIntArray(array1);



void SortLinesOfArray(int[,] arr ) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int k = 0; k < arr.GetLength(1); k++) {
        for(int j = 1; j < arr.GetLength(1); j++) {
            if (arr[i, j - 1] < arr[i, j]) {
                int temp = arr[i, j];
                arr[i, j] = arr[i, j - 1];
                arr[i, j - 1] = temp;
            }
        }
        }
    }
}

// *********************************************************************************************************************
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,                                              *
// которая будет находить строку с наименьшей суммой элементов.                                                        *
// *********************************************************************************************************************
Console.WriteLine("Input m of array dimention");
int firstDim2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int secondDim2 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array2 = new int[firstDim2, secondDim2];
FillIntArray(array2);
PrintIntArray(array2);
Console.WriteLine("Result = {0:0}", FindMinSumRow(array2));


int FindMinSumRow(int[,] arr) {
    int[] sums = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            sums[i] += arr[i, j];
        }
    }

    int minSum = sums[0];
    int minIndex = 0;

    for(int i = 1; i < sums.Length; i++) {
        if (minSum > sums[i]) {
            minSum = sums[i];
            minIndex = i;
        }
    }

    return minIndex;
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
     Console.WriteLine();
}
