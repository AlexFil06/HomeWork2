// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели  ");

int number = Convert.ToInt32(Console.ReadLine());

bool Сheckout(int numb)
{
    return numb == 6 || numb == 7;
}

if (number <= 7)
{
    bool result = Сheckout(number);
    Console.Write($"{number} -> ");
    Console.WriteLine(result ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Неверный день недели");
}