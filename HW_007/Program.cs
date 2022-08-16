//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
/*

double[,] CreateRandom2dArray2(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 1);

        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray2(m, n, min, max);
Show2dArray(array);
*/
//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

void FindElement(int[,] array, int rows, int columns)
{
    if(rows < array.GetLength(0) && columns < array.GetLength(1))
    Console.WriteLine(array[rows,columns]);
    else Console.WriteLine("Такого элемента не существует:(");
    
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] newArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(newArray);

Console.Write("Введите строку искомого элемента: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец искомого элемента: ");
int columns = Convert.ToInt32(Console.ReadLine());

FindElement(newArray, rows, columns);

*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}


/*
void ShowArray(double[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " "); 
    Console.WriteLine();
}

double[] MiddleValue(int[,] array) // method 1
{
    double[] newArray = new double[array.GetLength(0)];
    double summa = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa = summa + array[i,j];
        } 
        newArray[i] = Math.Round(summa / array.GetLength(1), 1);
        summa = 0;
    }
    return newArray;
}
*/

string MiddleValue(int[,] array) // Method 2
{
    string result = string.Empty;
    double summa = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa = summa + array[i,j];
        } 
        result = result + " " + Math.Round(summa / array.GetLength(1), 1);
        summa = 0;
    }
    return result;
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
string result = MiddleValue(array);
//ShowArray(newArray);
Console.WriteLine(result);