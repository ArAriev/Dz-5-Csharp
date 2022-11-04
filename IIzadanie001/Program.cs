//II. Реализовать следующие функции:
//1. Функцию, которая вычисляет число a в степени n
Console.Clear();
int Avn(int a, int n)
{
    int avn = 1;
        for(int count = 0; count < n; count++)
            {
                avn = avn * a;
            }
return avn;
}


Console.WriteLine("Введите чило которое необходимо возвести в степень");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите искомую степень числа");
int n = int.Parse(Console.ReadLine() ?? "0");
int x = Avn(a, n);
Console.WriteLine ($"Число {a} в степени {n} равно: {x}");