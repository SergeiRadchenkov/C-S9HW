/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Ackermann(int num1, int num2)
{
    if (num1 ==0) return num2 + 1;
    else if (num2 ==0) return Ackermann(num1 - 1, 1);
    else return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
}


int number1 = InputNum("Введите натуральное число значения M: ");
int number2 = InputNum("Введите натуральное число значения N: ");
if (number1 < 0 || number2 < 0) Console.WriteLine("Введено число не являющееся натуральным");
else
{
    int result = Ackermann(number1, number2);
    Console.WriteLine(result);
}