// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int length = InputNumber("Введите число соответствующее длине массива");
int[] array = FillArrayByNumbers(length);
PrintArray(array);
int positiveNumbers = GetAmountPositiveNumbers(array);
Console.WriteLine($"Количество введенных чисел больше 0: {positiveNumbers}");


int InputNumber(string text)
{
    Console.WriteLine(text);
    bool isNum = int.TryParse(Console.ReadLine(), out int number);
    if (isNum)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
        return -1;
    }
}

int[]FillArrayByNumbers(int number)
{
    int[] array = new int [number];
    for (int i = 0; i < number; i++)
    {
        int newElement = InputNumber($"Введите {i+1} элемент массива: ");
        array [i] = newElement; 
    }
    return array;
}

void PrintArray(int [] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine(message);
}

int GetAmountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i] > 0)
        {
           count+=1; 
        }
    }
    return count;
}