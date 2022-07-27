// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1,N));








////////////////////
// Console.WriteLine("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(m < n) // 2 < 6
// for (int i = m; i <= n; i++) // i = 2; 2 <= 6
// {
//     Console.Write(i);
// }
// else
// {
//     for(int i = n; i <= m; i++) // i = 6; 6 <= 2
//     {
//         Console.Write(i);
//     }
// }

// Console.WriteLine("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if(m < n) // 2 < 6
// for (int i = m; i <= n; i++) // i = 2; 2 <= 6
// {
//     Console.Write(i);
// }
// else
// {
//     for(int i = n; i <= m; i++) // i = 6; 6 <= 2
//     {
//         Console.Write(i);
//     }
// }



// Console.WriteLine("Введите число m: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int NaturalNumbers(int firstNumber, int secondNumber)
// {
//     if(firstNumber < secondNumber)
    
//     for (int i = firstNumber; i <= secondNumber; i++)
//     {
//         Console.WriteLine(i);
//     }
//     else
//     {
//         for(int i = firstNumber; i <= secondNumber; i++)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }