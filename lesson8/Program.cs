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

// *********************************************************************************************************************
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.                *
// *********************************************************************************************************************

Console.WriteLine("Input m of array dimention");
int firstDim3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int secondDim3 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Input m of array dimention");
int firstDim4 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input n of array dimention");
int secondDim4 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

if (secondDim3 != firstDim4) {
    Console.WriteLine("Wrong dimentions!");
    return;
}

int[,] array3 = new int[firstDim3, secondDim3];
int[,] array4 = new int[firstDim4, secondDim4];

FillIntArray(array3);
FillIntArray(array4);

PrintIntArray(array3);
PrintIntArray(array4);
PrintIntArray(MultipleMatrix(array3, array4));



int[,] MultipleMatrix(int[,] arr1, int[,] arr2) {
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++) {
        for(int j = 0; j < result.GetLength(1); j++) {
            result[i, j] = CalculateElement(arr1, arr2, i, j);
    
        }
    }

    return result;
}

int CalculateElement(int[,] arr1, int[,] arr2, int i, int j) {
    int elem = 0;

    for(int k = 0; k < arr1.GetLength(0); k++) {
        elem += arr1[i, k] * arr2[k, j];
    }

    return elem;
}

// *********************************************************************************************************************
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.                                    *
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.                     *
// *********************************************************************************************************************

Console.WriteLine("Input x of array dimention");
int firstDim5 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input y of array dimention");
int secondDim5 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input z of array dimention");
int thirdDim5 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

if (firstDim5 * secondDim5 * thirdDim5 > 90) {
    Console.WriteLine("Wrong dimention");
    return;
}

int[,,] array5 = new int[firstDim5, secondDim5, thirdDim5];
Fill3DArray(array5);
Print3DArray(array5);


void Print3DArray(int[,,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        
        for(int j = 0; j < arr.GetLength(1); j++) {
            
            for(int k = 0; k < arr.GetLength(2); k++){
                
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
                
            }

            Console.WriteLine();
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Fill3DArray(int[,,] arr) {
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            for(int k = 0; k < arr.GetLength(2); k++){
                int nextVal = random.Next(10, 99);
                while(!CheckValue(arr, nextVal)) {
                    nextVal = random.Next(10, 99);
                }
                
                arr[i,j,k] = nextVal;
                
            }
            
        }
    }
}

bool CheckValue(int[,,] arr, int val) {

    for (int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            for(int k = 0; k < arr.GetLength(2); k++){
                
                if (arr[i,j,k] == val) {
                    return false;
                }
                
            }
            
        }
    }

    return true;
}


// *********************************************************************************************************************
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.                                            *
// *********************************************************************************************************************
int n = 4;

int[,] array6 = new int[4, 4];
FillArray(array6);
PrintIntArray(array6);

void FillArray(int[,] arr) {
    
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int directionChanges = 0;
    int visits = n;
 
    for (int i = 0; i < n * n; i++) {
         arr[row, col] = i + 1;
         if (--visits == 0) {
            visits = n * (directionChanges % 2) + n * ((directionChanges + 1) % 2) - (directionChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            directionChanges++;
        }
        col += dx;
        row += dy;
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
     Console.WriteLine();
}
