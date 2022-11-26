//Д/З к уроку 7. Как не нужно писать код. Часть 1

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, colums];

//     for (int i = 0; i < rows; i++)  // внешний цикл будет проходится по всем строкам
//         for (int j = 0; j < colums; j++) // а внутренний по столбцам
//             array[i,j] = new Random().Next(minValue, maxValue) / 10.0;

//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // (0)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();    
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
//------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет

// int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];

//     for (int i = 0; i < rows; i++)  // внешний цикл будет проходится по всем строкам
//         for (int j = 0; j < colums; j++) // а внутренний по столбцам
//             array[i,j] = new Random().Next(minValue, maxValue);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();    
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a position of number of rows: ");
// int posm = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a position of number of colums: ");
// int posn = Convert.ToInt32(Console.ReadLine());

// int FindValueOfElement(int[,] array)
// {
//     int element = 0;
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == posm - 1 && j == posn - 1)
//                     element = array[i, j];
//             }
//     }
//     return element;
// }

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Console.WriteLine();

// if (posm < myArray.GetLength(0) && posn < myArray.GetLength(1)) 
//     {
//     Console.WriteLine("Value of element: " + FindValueOfElement(myArray));
//     }
// else 
//     {
//     Console.WriteLine("The element is missing in this array");
//     }
//------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   

// void ArithmeticMean(int[,] array)
// {
//     double sum = 0;
//     double count = 0;
//     double sumcolumn = 0;
//     Console.Write($"Arithmetic mean of the elements: ");
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             {
//                 sum += array[i,j];
//                 count++;
//                 sumcolumn = sum / count;
//             }
//         Console.Write($"{sumcolumn}; ");
//         sum = 0;
//         count = 0;
//     }   
// }

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Console.WriteLine();
// ArithmeticMean(myArray);