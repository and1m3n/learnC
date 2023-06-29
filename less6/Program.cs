// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел вы хотите ввести?: ");
int count =  Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(count);
int [] arrNum =new int[count];

void numPlus(int size){
for(int i = 0; i < count; i ++){
    Console.Write($"введите число {i+1}: ");
    int num  =  Convert.ToInt32(Console.ReadLine());
arrNum[i] = num;
}
}

void printArr(int [] arr){
    int j = 0;
    int plus = 0;
    Console.Write("Введенные числа : ");
    while (j < arr.Length){
        if(arr[j] > 0){
            plus++;
        }
Console.Write($"{arr[j]},");


j++;
    }
    Console.WriteLine();
    Console.Write($"Положительных чисел:{plus}!");
}
 numPlus(count);
 printArr(arrNum);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5);
int b1 = 2; 
int k1 = 5;
int b2 = 4; 
int k2 = 9;
//y = k1 * x + b1
//y = k2 * x + b2


void test(int b1, int k1, int b2, int k2){
double x = (double)(b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine();
Console.Write($"Х:{x},Y:{y}");
}

test(b1,k1,b2,k2);