// I. Реализовать следующие функции для работы с массивами:
//14. Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
Console.Clear();
void FillArray(int[] arr, int min, int max)    
    {
        for (int i=0; i < arr.Length; i++)
            arr[i] = new Random().Next(min, max);
    }
void PrintArray(int[] arr)                     
{
    for (int i=0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
bool CheckSort(int[] arr)                   
{
    bool a = true;
    for (int i=1; i < arr.Length; i++)
    {
        if (arr[i] < arr[i-1])
        a = false;      
    }
    return a;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int [size];
FillArray(arr, 1, 20);
PrintArray(arr);
bool x = CheckSort(arr);
Console.WriteLine($"{x}");