/*
Задача 66: Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double SumNum(int num1, int num2)
{
    if (num1 == 0) num1 = 1;
    if (num1 <= num2) return num1 + SumNum(++num1, num2);
    else return 0;
}


int number1 = InputNum("Введите натуральное число значения M: ");
int number2 = InputNum("Введите натуральное число значения N: ");
if (number1 < 0 || number2 < 0) Console.WriteLine("Введено число не являющееся натуральным");
else
{
    double result = SumNum(number1, number2);
    Console.WriteLine(result);
}