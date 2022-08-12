//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] InputArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент из {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void PositiveNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine($"Количество элементов больше нуля: {count}");
}

Console.WriteLine("Ведите желаемое количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = InputArray(size);

PositiveNumber(array);


//Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void CrossPoint(double k1, double k2, double b1, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;

    Console.WriteLine($"Координаты точки пересечения данных прямых: {x};{y} ");
}
Console.WriteLine("Найдем точку пересечения прямых y = k1*x + b1 и  y = k2*x + b2");

 Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

CrossPoint(k1, k2, b1, b2);
*/