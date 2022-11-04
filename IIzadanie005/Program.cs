// II. Реализовать следующие функции:
// 5. Функцию, складывающую два целых числа
Console.Clear();
int Sum(int a, int b)
{
    int sum = 0;            
    sum = a + b;
return sum;
}
Console.WriteLine("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int x = Sum(a, b);
Console.WriteLine($"Сумма чисел {a} и {b} равна: {x}" );