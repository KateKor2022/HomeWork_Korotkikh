// Task 10 Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
   int num1 = num / 10;
    return num1 % 10;
}

int num = new Random().Next(100,1000);
int result = SecondDigit(num);

Console.WriteLine($"Сгенерировано число: {num}");
Console.WriteLine($"Результат:  {result}");


//Task 13 Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

int ThirdDigit(int num)
{
    while(num > 999)
    {
       num = num / 10;
    }
    if(num > 99) return num % 10;
    else return -1;
   
    
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ThirdDigit(num);

if(result == -1)
{
    Console.WriteLine($"Задано число: {num} ");
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Задано число: {num} ");
    Console.WriteLine($"Третья цифра: {result}");
}*/

// Task 15  Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
string DayOfWeek(int day)
{
    if(day > 5 && day < 8) return "О да!!!";
    if(day > 0 && day < 6) return "Ну нет, иди работай";
    else return "Нет, такого дня недели нет";
}

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

string result = DayOfWeek(day);

Console.WriteLine($"Задано число: {day} ");
Console.WriteLine($"Этот день выходной? {result} ");

*/