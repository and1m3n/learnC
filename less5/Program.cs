// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] RandomArr (int arrsize){
    int [] resultArr = new int[arrsize];
    int count = 0;
for(int i = 0; i < arrsize; i++){
   resultArr[i] = new Random().Next(100,1000);
   if(resultArr[i] % 2 == 0){
    count++;
   }
}
Console.WriteLine($"количество четных чисел равно { count }");

return resultArr;
}

int [] res = RandomArr(10);

void ShowArr(int[] arr){
    int i = 0;
while(i < arr.Length){
    Console.Write(arr[i] + " ");
    i++;
}
}

ShowArr(res);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Mass(int sizearr){
 int [] randomArr = new int[sizearr];
 int summ = 0;
 for(int i = 0; i < sizearr; i++){
    randomArr[i] = new Random().Next(1, 5);
    if(i % 2 != 0){
        summ+=randomArr[i];
    }

 }

Console.WriteLine();
Console.WriteLine();
 Console.Write($"Массив рандомных элементов:");
 for(int j = 0; j < randomArr.Length; j++){
Console.Write(randomArr[j]+ " ");
 }
Console.Write($" сумма элементов, стоящих на нечётных позициях = {summ}");

} 
Mass(6);
Console.WriteLine();
Console.WriteLine();



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76;
void PlusNum(int masslength){
    double [] arr  = new double[masslength];
    for(int i = 0; i<masslength; i++){
        arr[i] = Math.Round(new Random().NextDouble()*10,2);
    }
    Console.Write("массив вещественных чисел ");
    for(int j = 0; j<arr.Length; j++){
        Console.Write(arr[j]+ " ");
    }
double max = arr[0];
double min = arr[0];
double result = 0;

for(int k = 0; k<arr.Length; k++){
if(arr[k] > max){
max = arr[k];
} 
if( arr[k] < min){
    min = arr[k];
}
    }

    result = max - min;
    Console.WriteLine($"разница  между максимальным и минимальным элементов массива = {Math.Round(result,2)}");

}

PlusNum(5);