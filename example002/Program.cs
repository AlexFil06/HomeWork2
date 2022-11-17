// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число  ");

int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int numb)
{

    while (numb > 999)
    {
        numb = numb / 10;
    }
    int res = numb % 10;
    return res;
}

if ( number > 99 ){
    int result = ThirdDigit(number);
    Console.WriteLine($"{number} -> {result}");
}
else {
Console.WriteLine($"{number} -> третьей цифры нет");
}