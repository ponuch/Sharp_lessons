using System.Collections;

// ***************************************************************************************************************************************
// Задача 19                                                                                                                             *
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.                             *
// ***************************************************************************************************************************************

Console.WriteLine("Input number");
int number = Math.Abs(Int32.Parse(Console.ReadLine())); //  skip any errors, let assume that input number is real

if (Validate(number)) {
    if (IsPalindrome(number)) {
        Console.WriteLine("Palindrome");
    }
    else {
        Console.WriteLine("Not palindrome");
    }
}
else {
    Console.WriteLine("Wrong number");
}

bool Validate (int number) {
    if (number < 10_000 || number > 99_999) {
        return false;
    }
    return true;
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

bool IsPalindrome(int number) {
    var arr = ParseNumber(number);
    bool result = true;
    for (int i = 0; i < arr.Length / 2; i++){
        if (arr[i] != arr[arr.Length - i -1]) {
            result = false;
            break;
        }
    }
    return result;
}

// ***************************************************************************************************************************************
// Задача 21                                                                                                                             *
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.                *
//                                                                                                                                       *
// A (3,6,8); B (2,1,-7), -> 15.84                                                                                                       *
//                                                                                                                                       *
// A (7,-5, 0); B (1,-1,9) -> 11.53                                                                                                      *
// ***************************************************************************************************************************************

var pointA = InputPoint();
var pointB = InputPoint();

Console.WriteLine("Distance = {0:0.00}",  GetDistance(pointA, pointB));

double GetDistance(Point3D pointA, Point3D pointB) {
    return Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2.0) + Math.Pow(pointB.Y - pointA.Y, 2.0)+ Math.Pow(pointB.Z - pointA.Z, 2.0));
}

Point3D InputPoint() {
    Console.WriteLine("Input X coord");
    int x = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Input Y coord");
    int y = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Input Z coord");
    int z = Int32.Parse(Console.ReadLine());

    return new Point3D(x, y, z);
}




// ***************************************************************************************************************************************
// Задача 23                                                                                                                             *
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.                                       *
// 3 -> 1, 8, 27                                                                                                                         *
// 5 -> 1, 8, 27, 64, 125                                                                                                                *
// ***************************************************************************************************************************************
Console.WriteLine("Input number");
int num = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++) {
    Console.Write("{0} ", Math.Pow(i, 3.0));
}

Console.WriteLine();




public struct Point3D {
    public Point3D (int x, int y, int z) {
        X = x;
        Y = y;
        Z = z;
    }    

    public int X {get;}
    public int Y {get;}
    public int Z {get;}
}

