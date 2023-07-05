// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void ShowArr(double[,] arr){
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();// переход на новую строку
}
}


double [,] Create2dArray(){
Console.WriteLine("введите число строк");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите число столбцов");
int colls = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите минимально допустимое значение");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите максимально допустимое значение");
int maxValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("__________task_1_____________");
double [,] createdArr =  new double[rows,colls];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colls; j++)
    {
        createdArr[i,j] = Math.Round((new Random().NextDouble()*(maxValue-minValue) + minValue),2);
    }
}
return createdArr;

}
double[,] arrReady = Create2dArray();
ShowArr(arrReady);
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int [,] arr1 = {{1,2,3,4},{4,3,2,1}};
void NumOfElement(int a,int b, int [,] arr){

    int numRows = arr.GetLength(0);
    int numCols = arr.GetLength(1);
    
        if(a >= 0 && a < numRows && b >= 0 && b < numCols){
Console.WriteLine($"Значение этого элемента: {arr[a,b]}");
        }
        else{
            Console.WriteLine($"такого числа в массиве нет");
        }
       }
Console.WriteLine("__________task_2_____________");
  
NumOfElement(0,1, arr1);
NumOfElement(1,0, arr1);
NumOfElement(0,7, arr1);
Console.WriteLine("_______________________");

Console.WriteLine("введите число строк");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите число столбцов");
int colls = Convert.ToInt32 (Console.ReadLine()); 
int [,] createdArrNew =  new int[rows,colls];
for (int i = 0; i < createdArrNew.GetLength(0); i++)
{
    for (int j = 0; j < createdArrNew.GetLength(1); j++)
    {
        createdArrNew[i,j] = new Random().Next(1,10);
    }
    Console.WriteLine();
} 

void avg(int [,] arr){

    // int rows = arr.GetLength(0);
    // int colls = arr.GetLength(1);
for (int i = 0; i < rows; i++){

for (int j = 0; j < colls; j++){
  Console.Write(arr[i,j] + " ");
}
Console.WriteLine();

}
Console.WriteLine("__________task_3_____________");
Console.WriteLine("Среднее арифметическое по столбцам:");
for(int k = 0; k < rows; k++){
    int summ = 0;
    for(int n = 0; n < colls; n++){
summ += arr[n,k];

    }
    double result = (double) summ/rows;
    Console.Write ($"{Math.Round(result,1)}  ");
    }

}



avg(createdArrNew);
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.