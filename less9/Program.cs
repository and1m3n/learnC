// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("task1_______________________________");
int numN = 8;
void ShowNum(int n){
if(n > 1) {
    ShowNum(n - 1);   
}
 Console.WriteLine(numN - n + 1);
}

ShowNum(numN);
Console.WriteLine("task2_______________________________");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int summ = 0;
void sumElem(int m,int n){
    if(m < n){
        summ+=m;
        sumElem(m + 1, n);
      
    }
      else{
        summ+=m;
Console.WriteLine($"сумма элементов  = {summ}");
      }   
}
sumElem(4,8);
Console.WriteLine("task3_______________________________");

// Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

    
        


     int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else{
            return -1 ;
        }

    }

    int m = 2;
    int n = 3;
    int result = AckermannFunction(m, n);
    Console.WriteLine($"A({m}, {n}) = {result}");

