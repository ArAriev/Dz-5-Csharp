// I. Реализовать следующие функции для работы с массивами:
// 8. Среднее арифметическое элеметов массива
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
int Average(int [] arr)                         
{
int avg = 0;
    for (int i=0; i<arr.Length; i++)
        {
            avg = avg+arr[i];
        }
    avg = avg/arr.Length;
    return avg;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, 1, 50);
PrintArray(arr);
int x = Average(arr);
Console.WriteLine($"Среднее арифметическое всех элементов массива равно: {x} ");
