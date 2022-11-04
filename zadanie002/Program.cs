// I. Реализовать следующие функции для работы с массивами:
//1. Поиск максимума
Console.Clear();
int Max(int [] arr)
    {
    int max = arr[0];
        for (int i=0; i<arr.Length; i++)
            if (arr[i]>max)
                max=arr[i];
    return (max);
    }


Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];

for (int i=0; i<size; i++)
        arr[i] =  new Random().Next(0,10);
Console.WriteLine("Ваш массив:  ");   
for (int i=0; i<size; i++)
    Console.Write($"{arr[i]} ");
Console.WriteLine();

int x = Max(arr);

Console.WriteLine($"Максимальное число в представленном массиве: {x}");
