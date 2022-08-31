
Console.WriteLine("Input number");
int number = Math.Abs(Int32.Parse(Console.ReadLine())); //  skip any errors, assume that number is real

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
