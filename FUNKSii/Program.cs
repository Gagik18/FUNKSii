using System;

class Program
{
    static void Main(string[] args)
    {
        // Задача 1: Напишите функцию, которая принимает два целых числа и возвращает их сумму.
        int sum = Add(3, 5);
        Console.WriteLine("Сумма: " + sum);

        // Задача 2: Напишите функцию, которая принимает радиус окружности и возвращает ее площадь.
        double area = CircleArea(10);
        Console.WriteLine("Площадь круга: " + area);

        // Задача 3: Напишите функцию, которая принимает строку и возвращает ее длину.
        int length = StringLength("Hello, World!");
        Console.WriteLine("Длина строки: " + length);

        // Задача 4: Напишите функцию, которая принимает массив целых чисел и возвращает наибольшее значение в массиве.
        int[] numbers = { 1, 2, 3, 4, 5 };
        int max = MaxValue(numbers);
        Console.WriteLine("Максимальное значение: " + max);

        // Задача 5: Напишите функцию, которая принимает число и возвращает его факториал.
        int factorial = Factorial(5);
        Console.WriteLine("Факториал: " + factorial);

        // Задача 6: Напишите функцию, которая принимает строку и проверяет, является ли она палиндромом.
        bool isPalindrome = IsPalindrome("radar");
        Console.WriteLine("Палиндром: " + isPalindrome);

        // Задача 7: Напишите функцию, которая принимает два массива целых чисел и возвращает новый массив, содержащий элементы обоих массивов.
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));

        // Задача 8: Напишите функцию, которая принимает число и возвращает true, если оно простое, и false в противном случае.
        bool isPrime = IsPrime(7);
        Console.WriteLine("Простое число: " + isPrime);

        // Задача 9: Напишите функцию, которая принимает строку и возвращает ее в обратном порядке.
        string reversedString = ReverseString("Hello");
        Console.WriteLine("Обратная строка: " + reversedString);

        // Задача 10: Напишите функцию, которая принимает двумерный массив чисел и возвращает сумму всех элементов.
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
        int sumOfElements = SumOfMatrixElements(matrix);
        Console.WriteLine("Сумма элементов матрицы: " + sumOfElements);

        Console.ReadLine();
    }

    // Задача 1
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Задача 2
    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Задача 3
    static int StringLength(string str)
    {
        return str.Length;
    }

    // Задача 4
    static int MaxValue(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    // Задача 5
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    // Задача 6
    static bool IsPalindrome(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
                return false;
        }
        return true;
    }

    // Задача 7
    static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        array1.CopyTo(mergedArray, 0);
        array2.CopyTo(mergedArray, array1.Length);
        return mergedArray;
    }

    // Задача 8
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    // Задача 9
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Задача 10
    static int SumOfMatrixElements(int[,] matrix)
    {
        int sum = 0;
        foreach (int element in matrix)
        {
            sum += element;
        }
        return sum;
    }
}
