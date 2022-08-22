//Задача 54: Задайте двумерный массив. Напишите программу
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] LessArray(int[,] array)
{  
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int m=0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i,m] < array[i,m + 1]) 
                {
                    temp = array[i,m + 1];
                    array[i,m + 1] = array[i, m];
                    array[i,m] = temp; 
                }
            }   
        }  
    }
    return array;
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

Show2dArray(LessArray(array));

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine("Строка " + i + ": " + array[i]); 
    Console.WriteLine();
}

int[] SummaStrok(int[,] array)
{   
    int[] resultArray = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        for(int j=0; j < array.GetLength(1); j++)
        {
            summa = summa + array[i,j];
        }
        resultArray[i] = summa;
    }
   
    return resultArray;
}

int MinSumIndex(int[] resultArray)
{
    int result = 0;
    int min = resultArray[0];
    for(int k = 0; k < resultArray.GetLength(0) - 1; k++)
    {
        if (resultArray[k + 1] < min)
        {
            min = resultArray[k+1];
            result = k + 1;
        }
        
    }
    return result;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов, отличное от количества строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
int[] resultArray = SummaStrok(array);

Console.WriteLine("Сумма элементов массива:");
ShowArray(resultArray);

Console.WriteLine();
Console.WriteLine("Строка с минимальной суммой элементов: " + MinSumIndex(resultArray));
*/


//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(0); j++)
        {
            newArray[i,j] = array1[i,j] * array2[i,j];
        }
    }
    return newArray; 
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов, отличное от количества строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array1 = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Массив 1:");
Show2dArray(array1);

int[,] array2 = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Массив 2:");
Show2dArray(array2);

int[,] newArray = MultiplyMatrix(array1, array2);
Console.WriteLine("Массив 1 * Массив 2:");
Show2dArray(newArray);
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
/*

int[,,] CreateRandom3dArray(int rows, int columns, int table, int minValue, int maxValue)
{
    int[,,] newArray = new int[rows,columns,table];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < table; k++)
            {
                newArray[i,j,k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return newArray;
}
*/
/*
void CreateRandom3dArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void Show3dArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
             Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество таблиц: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[m, n, l];

CreateRandom3dArray(array3D);
Show3dArray(array3D);
*/

//Задача 62. Заполните спирально массив 4 на 4.
/*
int[,] Spiral(int i, int j)
{
    int[,] SpiralArray = new int[i,j];
    int num = 1, max = i*j;
    int iMin = 0, iMax = i - 1;
    int jMin = 0, jMax = j - 1;

    while (num <= max)
    {
        for(int k = jMin; num <= max && k <= jMax; k++)
        {
            SpiralArray[iMin,k] = num;
            num++;
        }
        iMin++;
        for(int k = iMin; num <= max && k <= iMax; k++)
        {
            SpiralArray[k,jMax] = num++;
        }
        jMax--;
        for(int k = jMax; num <= max && k >= jMin; k--)
        {
            SpiralArray[iMax,k] = num++;
        }
        iMax--;
        for(int k = iMax; num <= max && k >= iMin; k--)
        {
            SpiralArray[k,jMin] = num++;
        }
        jMin++;
    }
    return SpiralArray;
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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Spiral(rows, columns);
Show2dArray(newArray);
*/