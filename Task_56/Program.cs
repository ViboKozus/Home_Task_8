Console.Clear(); 
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов."); 
 
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

int MinSumLine = 0;
int SumLine = SumLineNumbers(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumLine = SumLineNumbers(arr, i);
  if (SumLine > tempSumLine)
  {
    SumLine = tempSumLine;
    MinSumLine = i;
  }
}

Console.WriteLine($"\n{MinSumLine+1} - номер строки с минимальной суммой ({SumLine}) элементов ");

int SumLineNumbers(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
}

