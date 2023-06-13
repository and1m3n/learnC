//***** Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


void BackNum(int num)
    {
        if (num > 999 || num < 100)
        {
            Console.WriteLine(" Введено некорректное число введите трехзначное число");
           
        }
        else
        {
            
            Console.WriteLine($" вторая цифра: {num / 10 % 10}");
        }
    }
     Console.WriteLine("Введите трехзначное число");
     int num1 = Convert.ToInt32(Console.ReadLine());
    BackNum(num1); 



//***** Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void BackThird(int num){
if(num > 99){
Console.WriteLine($" третья цифра заданного числа {num % 10}");
} else {
Console.WriteLine("Некорректно введено значение необходимо ввести число больше 99");
}
} 
 Console.WriteLine("Введите трехзначное число");
     int num2 = Convert.ToInt32(Console.ReadLine());
    BackThird(num2); 


//***** Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void DayWeek(int num){
if(num <= 0 || num > 7){
    Console.WriteLine("некорректный ввод введите день недели (число от 1 до 7)");
}
if( num == 6 || num == 7){
     Console.WriteLine("День является выходным");
}
if(num > 0 && num < 6){
    Console.WriteLine("День является будниим днем ");
}
}
 Console.WriteLine("Введите день недели 1-7");
     int day = Convert.ToInt32(Console.ReadLine());
    DayWeek(day); 

    