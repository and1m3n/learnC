// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Cube (int a, int b){
    int count = 0;
    int res = 1;
while(count < b){
res = res*a;
count ++;
}
return res;}
int a = Cube(3,5);
int b = Cube(2,4);
Console.WriteLine(a);
Console.WriteLine(b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Summ(int num){
int sum = 0;
while(num > 0){
    sum = sum  + num % 10;
    num /=10;
}
Console.WriteLine($"Сумма чисел равна {sum}");
}

Summ(9012);

// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int [] CreateNewArr(int size_arr){
    int [] randomArr = new int[size_arr];
    for(int i = 0; i<size_arr; i++){
randomArr[i] = new Random().Next(0,99);
    }
    Console.WriteLine();
    return randomArr;
}


int [] myArr = CreateNewArr(10);

void PrintArr(int [] array){
Console.WriteLine("You array is");
for(int i = 0; i<array.Length; i++){
    Console.Write($"{array[i]+ "_"}");
}
}
PrintArr(myArr);

