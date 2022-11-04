// I. Реализовать следующие функции для работы с массивами:
// 10. Подсчёт количества вхождений элемента в массив
Console.Clear();
void FillArray(int[] arr, int min, int max)    
    {
        for (int i=0; i<arr.Length; i++)
            arr[i] = new Random().Next(min, max);
    }
void PrintArray(int[] arr)                     
{
    for (int i=0; i<arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int Count(int[] arr, int n)                   
{
    int count=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]==n)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int [size];
FillArray(arr, 0, 10);
PrintArray(arr);
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int x = Count(arr, n);
Console.WriteLine($"Число {n} встречается в массиве {x} раз ");