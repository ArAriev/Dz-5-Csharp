// II. Реализовать следующие функции:
// 2. Функцию, которая вычисляет факториал числа n
Console.Clear();
int Factorial(int n)
{
    int fct = 1;
        for(int count = 1; count <= n; count++)
            {
                fct = fct * count;
            }
return fct;
}
Console.WriteLine("Введите чило, факториал которого необходимо вычислить");
int n = int.Parse(Console.ReadLine() ?? "0");
int x = Factorial(n);
Console.WriteLine ($"факториал числа {n} равен: {x}");