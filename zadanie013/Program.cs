// I. Реализовать следующие функции для работы с массивами:
// 13. Подсчёт количества нечётных элементов в массиве
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
int UnevenCount(int[] arr)                   
{
    int count=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2!=0)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int [size];
FillArray(arr, 1, 20);
PrintArray(arr);
int x = UnevenCount(arr);
Console.WriteLine($"Количество нечетных элементов в массиве равно: {x} ");
