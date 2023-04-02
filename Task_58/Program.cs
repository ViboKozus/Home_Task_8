Console.Clear(); 
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц."); 
 
Console.Write("Задайте размер матрицы: "); 
int N; 
int.TryParse(Console.ReadLine()!, out N); 
int[,] FtMartrix = new int[N, N];
int[,] SecMartrix = new int[N, N]; 
Console.WriteLine("1-я Матрица: ");
for (int i = 0; i < N; i++) 
{ 
    for (int j = 0; j < N; j++) 
    { 
        FtMartrix[i, j] = new Random().Next(1, 10); 
        Console.Write($"{FtMartrix[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

Console.WriteLine("2-я Матрица: ");
for (int i = 0; i < N; i++) 
{ 
    for (int j = 0; j < N; j++) 
    { 
        SecMartrix[i, j] = new Random().Next(1, 10); 
        Console.Write($"{SecMartrix[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

int[,] ResultMartrix = new int[N, N];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        for (int k = 0; k < N; k++)
        {
            ResultMartrix[i, j] = ResultMartrix[i, j] + (FtMartrix[i, k] * SecMartrix[k, j]);
        }
    }
}
Console.WriteLine("Результат произведение двух матриц:   ");
for (int i = 0; i < ResultMartrix.GetLength(0); i++)
{
    for (int j = 0; j < ResultMartrix.GetLength(1); j++)
    {
        Console.Write($"{ResultMartrix[i, j], -2} ");
    }
    Console.WriteLine(); 
}