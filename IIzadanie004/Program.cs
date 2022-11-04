// II. Реализовать следующие функции:
// 4. Функцию, которая проверяет является ли заданное число n полиндромом
Console.Clear();
bool Polyndrom(string a)
    {
        bool b = false;
        int index = a.Length - 1;
        for (int i = 0; i <= index; i++)
            {
                if(a[i] == a[a.Length - 1])
                b = true;
                index --;
            }
    return b;
    }

Console.WriteLine("Введите целое чиcло которое необходимо проверить на полиндром");
int n = int.Parse(Console.ReadLine() ?? "0");
string a = n.ToString();
bool x = Polyndrom(a);
Console.WriteLine($"{x}");