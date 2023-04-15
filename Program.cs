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

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет

РЕШЕНИЕ:
_________________________

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

double[,] randomArray = new double[m, n];

Console.Write("Введите позицию строки: ");
int m2 = int.Parse(Console.ReadLine());

Console.Write("Введите позицию столбца: ");
int n2 = int.Parse(Console.ReadLine());

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
            Console.Write($"{ randomArray[i, j]:F2} ");
}
Console.WriteLine();
}
}
Massiv(m, n);

if (m2 < 1 || n2 < 1)
    Console.Write("Отрицательные не могут быть");
else if (m2 <= m + 1 && n2 <= n + 1)
    Console.Write($"Значение элемента равно { randomArray[m2 - 1, n2 - 1]:F2} ");
else Console.Write("Нет такого элемента");


___________________________ 

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

РЕШЕНИЕ: 
_____________________________

*/

Console.Write("Задайте количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] randomArray = new int[m, n];

void Massiv(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArifmeticMean(int m, int n)
{
    Console.Write("Среднее арифметическое столбцов: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i, j];
        }
        Console.Write($"{sum / (i):F1}; ");
    }
}
Massiv(m, n);
ArifmeticMean(m, n);




