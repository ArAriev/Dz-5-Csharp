// II. Реализовать следующие функции:
// 6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
Console.Clear();
bool Simple(int n)
    {
        bool b = true;
        int count = 0;
        for (int c = 1; c <= n; c++)
        {
            if (n % c == 0)
            count++;
                if(count > 2)
                b = false;
        }
    return b;
    }
Console.WriteLine("Введите целое чиcло которое необходимо проверить");
int n = int.Parse(Console.ReadLine() ?? "0");
bool x = Simple(n);
Console.WriteLine($"{x}");
