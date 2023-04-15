/*
ДОМАШНЕЕ ЗАДАНИЕ 

Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 

Console.Write("Введите размер массива m: ");
int m = int.Parse(Console.ReadLine()); 

Console.Write("Введите размер массива n: ");
int n = int.Parse(Console.ReadLine()); 

double[,] randomArray = new double[m, n];

void Massiv(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
            Console.Write($"{randomArray[i, j]:F2} ");
        }

    }

}
Massiv(m, n);
_________________________________ 


*/ 

