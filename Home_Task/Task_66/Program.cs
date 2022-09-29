// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num2;

int Sum(int number1, int number2, int q)
{
    if (number2 != number1)
    {
        q += number1;
        return Sum(number1 + 1, number2, q);
    }
    return q;
}
Console.Write(Sum(num1,num2,sum));

