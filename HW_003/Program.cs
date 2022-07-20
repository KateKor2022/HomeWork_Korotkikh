// Задача 19 Проверка палиндрома

void Palindrom(int num)
{
    int num1; 
    int current;
    int sum = 0;
    num1 = num;
    while(num > 0)
    {
        current = num % 10;
        sum = sum * 10 + current;
        num = num / 10;
    }
    if(num1 == sum) Console.WriteLine("Ваше число палиндром!");
    else Console.WriteLine("Ваше число не палиндром!");
}

Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);


// Задача 21 Длина отрезка в 3Д
/*
double SizeLine(double x1, double y1, double z1, double x2, double y2, double z2 )
{
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
}

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = SizeLine(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Длина отрезка: {result} ");
*/
// Таблица кубов от 1 до N
/*
void Cube(int N)
{
    int current = 1;
    int Num;
    while(N < 1)
    {
        Console.WriteLine("Число должно быть больше единицы, попробуйте снова: ");
        N=Convert.ToInt32(Console.ReadLine());
    }
    
    while(current <= N)
    {
        Num = current * current * current;
        Console.Write(Num + " ");
        current++;
    }
}
Console.Write("Введите число больше единицы: ");
int N = Convert.ToInt32(Console.ReadLine());

Cube(N);
*/