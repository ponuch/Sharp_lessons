using System.Collections;

// *****************************************************************************************************************************
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. *
// *****************************************************************************************************************************


Console.WriteLine("Input number");
int number = Math.Abs(Int32.Parse(Console.ReadLine())); //  skip any errors, let assume that input number is real

// check number and calculate second digit
if (validate(number)) {
    int result = findDigit(number);
    Console.WriteLine("Second digit = {0:G}", result);
}
else {
    Console.WriteLine("You input wrong number");
}

bool validate( int num) {
    if (num > 99 && num < 1000) {
        return true;
    }
    return false;
}

int findDigit(int num) {
    int intermediateResult = num / 10;
    return intermediateResult % 10;
}

// ******************************************************************************************************************************
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.             *
// ******************************************************************************************************************************



Console.WriteLine("Input number");
int checkedNumber = Math.Abs(Int32.Parse(Console.ReadLine())); //  skip any errors, let assume that input number is real
if(validateNumber(checkedNumber)) {
    int[] arr = parseNumber(checkedNumber);
    Console.WriteLine("Third digit = {0:G}", arr[2]);
}
else {
    Console.WriteLine ("Wrong number, it must be greater than 99");
}

int[] parseNumber(int num) {
    var list = new List<int>();
    while (num > 0) {
        var digit = num % 10;
        num /= 10;
        list.Add(digit);
    }
    list.Reverse();
    return list.ToArray<int>();
}


bool validateNumber( int num) {
    if (num > 99) {
        return true;
    }
    return false;
}

// ***************************************************************************************************************************************
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*
//****************************************************************************************************************************************
Console.WriteLine("Input the day of the week");
int dayOfWeek = Math.Abs(Int32.Parse(Console.ReadLine())); //  skip any errors, let assume that input number is real

if (checkDay(dayOfWeek)) {
    Console.WriteLine("It's a weekend, you have to go to the bar!");
}
else {
    Console.WriteLine("Unfortunally, you have to work :(");
}

bool checkDay(int dayOfWeek) {
    switch (dayOfWeek) {
        case 6: 
        case 7:
            return true;
        default:
            return false;
    }
}
