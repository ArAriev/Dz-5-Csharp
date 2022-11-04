// I. Реализовать следующие функции для работы с массивами:
//3. Поиск суммы элементов массива
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

int Summ(int [] arr)                            
{
    int sum = 0;
    for (int i=0; i<arr.Length; i++)
        sum = sum + arr[i];
    return sum;
}
Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];

FillArray(arr, 0, 10);
PrintArray(arr);
int x = Summ(arr);
Console.WriteLine($"Сумма массива равна: {x}");
