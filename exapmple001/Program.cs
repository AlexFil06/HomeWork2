// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число  ");

int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int numb)
{
    int res = numb / 10 % 10;
    return res;
}

if (number > 99 && number < 1000)
{
    int result = SecondNumber(number);
    Console.WriteLine(result);
}
else
{
    Console.Write("Число не трехзначное");
}
