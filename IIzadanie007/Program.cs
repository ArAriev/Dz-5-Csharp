// II. Реализовать следующие функции:
// 7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
Console.Clear();
bool Even(int n)
{
    bool b = true;
        if (n % 2 != 0)
            b = false;
return b;
}

Console.WriteLine("Введите целое чиcло которое необходимо проверить");
int n = int.Parse(Console.ReadLine() ?? "0");
bool x = Even(n);
Console.WriteLine($"{x}");