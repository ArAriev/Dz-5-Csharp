// II. Реализовать следующие функции:
// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
Console.Clear();
int Sum(int n)
{
    int a = 0;
    int sum = 0;
        while(n >= 1)
        {
           a = n % 10;
           n = n / 10;
           sum += a; 
        }
return sum;
}


Console.WriteLine("Введите целое чиcло, сумму цифр которого необходимо вычислить");
int n = int.Parse(Console.ReadLine() ?? "0");
int x = Sum(n);
Console.WriteLine($"Cумма цифр числа {n} равна {x}");