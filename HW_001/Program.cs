// Task 2: Программа принимает на входе 2 числа, на выходе выдает какое число наибольшее

int a, b;
 
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
 
if(a > b) Console.WriteLine("max = " + a + " min = " + b);
if(a < b) Console.WriteLine("max = " + b + " min = " + a);
 
else Console.WriteLine("Числа равны");

 
// Task 4 Программа принимает на вход три числа и выдает максимальное
/*
int a, b, c;
 
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());
 
int max = a;
 
if(a == b && b == c) Console.WriteLine("Числа равны");
 
else
 {
    if(b > max) max = b;
    if(c > max) max = c;
    Console.WriteLine(max);
 }
 */
 
 //Task 6 Программа принимает на вход число и выводит информацию является ли оно четным
/*
int a;
 
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
 
if(a % 2 == 0) Console.WriteLine("Четное");
 
else Console.WriteLine("Нечетное");
*/
 
//Task 8 Программа на входе принимает число, а на выходе показывает все четные от 1 до N
/*
int N;
int current = 2;
 
Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
 
while(current <= N)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/