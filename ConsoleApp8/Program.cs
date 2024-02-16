
/*Сумма ряда (2n!)^n*/

Console.WriteLine("Enter n: ");
var n = int.Parse(Console.ReadLine()!);


var ans = Enumerable.Range(1, n).Aggregate(0, (x, y) => x + (int)Math.Pow(2 * Factorial(y), y));
if (ans > 0)
    Console.WriteLine("Answer:\n{0}", ans);
else
    Console.WriteLine("Value is over int");


static int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}