#pragma warning disable 
Console.Clear(); 
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива."); 
 
Console.Write("Введите кол-во строк: "); 
int n; 
int.TryParse(Console.ReadLine()!, out n); 
Console.Write("Введите кол-во столбцов: "); 
int m; 
int.TryParse(Console.ReadLine()!, out m); 
 
int[,] arr = new int[n, m]; 

for (int i = 0; i < n; i++) 
{ 
    for (int j = 0; j < m; j++) 
    { 
        arr[i, j] = new Random().Next(1, 10); 
        Console.Write($"{arr[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    Console.WriteLine(); }

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j], -2} ");
    }
    Console.WriteLine(); 
}