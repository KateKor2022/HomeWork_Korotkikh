
//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N.

void ShowNums(int n, int m)
{
    if(m > n)
    {
        Console.Write(m + " ");
        if(m != n) ShowNums(n, m - 1);
    }
    else
    {
        Console.Write(m + " ");
        if(m != n) ShowNums(n, m + 1);
    }   
}

Console.Write("Input first number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int m = Convert.ToInt32(Console.ReadLine());
ShowNums(n, m);


//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

/*
int SummaElements(int n, int m)
{
    if(m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if(m != n) return m + SummaElements(n, m + 1);
    return n;
}

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SummaElements(n,m)}");
*/

//Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

/*
int Akkerman(int m, int n)
{
    if (m == 0 ) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 1;
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m,n));
*/