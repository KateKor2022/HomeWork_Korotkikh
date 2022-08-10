//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size]; // выделили память под массив
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); //генерируем массив
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
    Console.WriteLine();
}

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

int min = 100;
int max = 999;

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int result = EvenNumber(array);
Console.WriteLine($"Количество четных чисел в массиве: {result}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); 
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
    Console.WriteLine();
}

int SummaDigit(int[] array)
{
    int sum = 0;
    for(int i= 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите необходимый размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное возможное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);

ShowArray(array);

int result = SummaDigit(array);
Console.WriteLine($"Сумма четных эелементов массива: {result}");
*/
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); 
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
    Console.WriteLine();
}

int MinMaxDifference(int[] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    int result = max - min;
    return result;
}

Console.Write("Введите необходимый размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное возможное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);

ShowArray(array);

int result = MinMaxDifference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");
*/