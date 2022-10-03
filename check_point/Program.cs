string[] words = {"Hello", "2", "world", ":-)", "123232", "qwe", "qwerty", "абырвалг"};
string[] resultWords = new string[GetResultArraySize(words)];
PrintStringArray(words);

FillResultArray(words, resultWords);

PrintStringArray(resultWords);

int GetResultArraySize(string[] arr) {
    int size = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (words[i].Length <= 3) {
            size++;
        }
    }
    return size;
}

void FillResultArray(string[] arr, string[] result) {
    int index = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i].Length <= 3) {
            result[index] = arr[i];
            index++;
        }
    }
}

void PrintStringArray(string[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}





