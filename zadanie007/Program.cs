// I. Реализовать следующие функции для работы с массивами:
// 7. Печать массива на экран
Console.Clear();
void FillArray(int [] arr, int min, int max)    
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
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, 1, 99);
PrintArray(arr);
