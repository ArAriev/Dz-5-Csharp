// I. Реализовать следующие функции для работы с массивами:
// 6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
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
bool NumFind(int[] arr, int n)                   
   {
    bool a = false;
    for (int i=0; i<arr.Length; i++)
        if (arr[i] == n)
            a = true;        
return a;             
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, 1, 50);
PrintArray(arr);
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

bool x = NumFind(arr, n);
Console.WriteLine($"{x}");
