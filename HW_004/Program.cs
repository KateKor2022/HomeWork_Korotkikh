//Task 25   Цикл принимает на вход два числа А и Б
// и возводит число А в натуральную степень Б

void  Stepen(double a, int b)
{
    int i = 1;
    double count = 1;
    while(i <= b)
    {
        count = count * a;
        i++;
    }
    Console.WriteLine($"Результат: {count}");
}

Console.WriteLine("Здравствуйте, я программа возведения в степень!");

Console.WriteLine("Пожалуйста, введите любое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Спасибо, теперь введите натуральную степень: ");

int b = Convert.ToInt32(Console.ReadLine());

Stepen(a, b);

 
 //Task 27 Программа принимает число, выдает сумму цифр
/*
 int SummaDigits(int num)
 {
    int summ=0;
    if (num < 0) num = num * -1; 
    while(num != 0)
    {
        summ = summ + num % 10;
        num = num / 10;
    }
    return summ;
 }

 Console.WriteLine("Пожалуйста, введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваш резульат {SummaDigits(num)}");
*/

// Task 29 Программа задает массив из 8 элементов и выводит их на экран
/*
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

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
    Console.WriteLine();
}

int[] array = InputArray(8);
ShowArray(array);
*/