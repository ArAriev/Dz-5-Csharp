// I. Реализовать следующие функции для работы с массивами:
//4. Поиск произведения элементов массива
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

int Multy(int[] arr)                            
{
    int s = 1;
    for (int i=0; i<arr.Length; i++)
        s = s * arr[i];
    return s;
}
Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[size];

FillArray(arr, 1, 9);
PrintArray(arr);
int x = Multy(arr);
Console.WriteLine($"Произведение массива равно: {x}");
