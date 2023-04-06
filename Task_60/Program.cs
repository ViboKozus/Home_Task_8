Console.Clear(); 
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента."); 
 
int[,,] arr = new int[2, 2, 2]; 
List <int> num = new List<int> ();
for (int i = 10; i < 100; i++)
    num.Add(i);

for (int i = 0; i < arr.GetLength(0)&& num.Count > 0; i++)
{
    for (int j = 0; j < arr.GetLength(1)&& num.Count > 0; j++)
    {
        for (int k = 0; k < arr.GetLength(2)&& num.Count > 0; k++)
        {
            int rant = new Random().Next(0, num.Count);
            arr[i, j, k] = num[rant];
            num.RemoveAt(rant);
        }
    }
}
//foreach (var item in arr)
    //Console.Write($"{item} ");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write($"{arr[i, j, k],2} ({i}, {j}, {k}) ");
        }
    }
    Console.WriteLine();
} 