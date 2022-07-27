// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число M:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число N:");
int firstNumber = int.Parse(Console.ReadLine());

void SumNumbers (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма элементов от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    SumNumbers(M, N, sum);
}
SumNumbers(secondNumber, firstNumber, 0);







// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int Sum(int firstNumber, int secondNumber)
// {
//     return firstNumber + secondNumber;
// }
// Console.WriteLine(Sum(M,N));