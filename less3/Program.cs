//*****Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double ThreeD (int xA, int xB, int yA, int yB,int zA, int zB){
    double LongLine = Math.Round(Math.Sqrt((xB -xA)*(xB -xA) +(yB -yA)*(yB -yA) +(zB -zA)*(zB -zA) ),2);
    return LongLine;
}
Console.WriteLine("Введите координаты X от А");
 int xcoordA = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты Y от А");
 int ycoordA = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты X от B");
 int xcoordB = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты Y от B");
 int ycoordB = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите координаты Z от B");
 int zcoordB = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты Z от B");
 int zcoordA = Convert.ToInt32(Console.ReadLine());
 
 
 double dist = ThreeD(xcoordA,xcoordB,ycoordA,ycoordB,zcoordA,zcoordB);
 Console.WriteLine($"растояние между A и B {dist}");


//***** Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Сube(int numN){
    int current = 1;
    while(current <= numN){
        double res = Math.Pow(current,3);
         Console.WriteLine($"- {res} -");
         current++;
    }
}

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
Сube(numberN);



//*****Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine()); 

void Polindrom(int num){
int n = num;
int numInter = num;
int m = 0;
int count = 0;

while(numInter > 0){
    count = count + 1;
    numInter = numInter / 10;};
if(count!= 5){
    Console.WriteLine($"Введите ПЯТИЗНАЧНОЕ! Количество введенных вами цифр = {count} ");
} else{
while(Convert.ToBoolean(n))
{
    m = m * 10 + n % 10;
    n = n / 10;
}
if( m == num){
 Console.WriteLine("Полиндром");
} else{
    Console.WriteLine("Не Полиндром");
}

}

}

Polindrom(num);
