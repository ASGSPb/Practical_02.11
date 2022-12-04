// Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите интервал ограниченный значениями M и N");
Console.WriteLine();

Console.Write("Введите M = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();



Console.WriteLine("Сумма элементов указанного промежутка равна = " + CountingInterval(n,m));
Console.WriteLine();



int CountingInterval(int n, int m)
{
 int result = 0;
 for (int i = m; i <= n; i++) result += i;
 return result;
}
int SumRec(int n)
{
 if (n == 0) return 0;
 else return n + SumRec(n - 1);
}

