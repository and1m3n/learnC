

class Program
{
    static void Main()
    {
        Parity(10);
        BigMinNum(100, 20);
        BigNum(1000, 40, 100);
        Nums2(10);
    }

    static void BigMinNum(int num1, int num2)
    {
        if (num1 < num2)
        {
            Console.WriteLine($"{num2} большее число, {num1} меньшее число");
        }
        else
        {
            Console.WriteLine($"{num1} большее число, {num2} меньшее число");
        }
    }

    static void BigNum(int num1, int num2, int num3)
    {
        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        Console.WriteLine($"Из 3-х чисел Большее число {max}");
    }

    static void Parity(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine($"число {num} является четным");
        }
        else
        {
            Console.WriteLine($"число {num} является не четным");
        }
    }

    static void Nums2(int n)
    {
        int count = 1;
        while (n >= count)
        {
            if (count % 2 == 0)
            {
                Console.WriteLine($"{count} четное число");
            }
            else
            {
                Console.WriteLine("-");
            }
            count++;
        }
    }
}
