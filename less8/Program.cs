// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] CreateArr(int colls, int rows){
int [,]createdArr = new int[colls,rows];
for (int i = 0; i < colls; i++)
{
    for (int j = 0; j < rows; j++)
    {
        createdArr[i,j] = new Random().Next(1,10);
        
    }
   
}
 return createdArr;
}
void ShowArr(int[,] arr){
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j]+" ");
    }
    Console.WriteLine();
}
}
int[,] newArr = CreateArr(3,3);
Console.WriteLine("______________task1__start____________________");
ShowArr(newArr);
Console.WriteLine("______________________________________________");


int[,] ReverseArr (int[,] arr){
 int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int[,] reversedArr = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            
            int[] tempArr = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                tempArr[j] = arr[i, j];
            }

            
            Array.Sort(tempArr);
            Array.Reverse(tempArr);

           
            for (int j = 0; j < cols; j++)
            {
                reversedArr[i, j] = tempArr[j];
            }
        }

        return reversedArr;
    }


int [,] reversedArrray = ReverseArr(newArr);
ShowArr(reversedArrray);
Console.WriteLine("______________task1___end_____________________");

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] newArr2 = CreateArr(4,4);
Console.WriteLine("______________task2__start____________________");
ShowArr(newArr2);

void MinValueString(int[,] arr){
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int minValue = 99999;
    int summ = 0;
    int numstring = 0;
 for (int i = 0; i < rows; i++)
        {
            
           
            for (int j = 0; j < cols; j++)
            {
               summ +=  arr[i,j];
              
            }
if( minValue > summ){
minValue = summ;
numstring = i+1;
summ = 0;
}
else{
summ = 0;
}
             
            

           
           
        }
        Console.WriteLine("______________________________________________");
        Console.WriteLine(  "наименьшая сумма элементов = "+ minValue + " находится в строке " + numstring);

        //Console.WriteLine (minValue);

}


MinValueString(newArr2);
Console.WriteLine("______________task2__end____________________");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
  
Console.WriteLine("______________task3__start____________________");
        int[,] matrix1 = CreateArr(2,2);
        int[,] matrix2 = CreateArr(2,2);
        ShowArr(matrix1);
        Console.WriteLine("______________________________________________");
        ShowArr(matrix2);
         Console.WriteLine("______________________________________________");


     int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

      
        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }

    int [,] sumMaxtrix = MultiplyMatrices(matrix1,matrix2);
  Console.WriteLine("______________________________________________");
    ShowArr(sumMaxtrix);
    Console.WriteLine("______________task3__end____________________");

//     Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("______________task4__start____________________");
int[,,] CreateArr3D(int list,int colls, int rows){
int [,,]createdArr = new int[list,colls,rows];
for (int i = 0; i < list; i++)
{
    for (int j = 0; j < colls; j++)
    {
        for (int k = 0; k < rows; k++)
        {
            createdArr[i,j,k] = new Random().Next(1,10);
        }
        
        
    }
   
}
 return createdArr;
}
void ShowArr3D(int[,,] arr){
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write(arr[i,j,k]+ $"({i},{j},{k}) ");
        }
        
         Console.WriteLine(); 
    }
     

}
 
}
 int [,,] threeD = CreateArr3D(2,2,2);
 ShowArr3D(threeD);
     Console.WriteLine("______________task4__end____________________");

//      Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

    