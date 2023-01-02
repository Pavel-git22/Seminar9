
// //Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// //N = 5 -> "1, 2, 3, 4, 5"
// //N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNUm ( int num)
// {
//     if(num>=1)
//     {
//     PrintNUm(num-1);
//     Console.Write(num+" ");
//     }
// }

// PrintNUm(100);




// int FindSum (int num)
// {
//     if(num>0) 
//     {
//         return FindSum(num/10) + num % 10;
//     }
//     else
//     return num;
// }

// int result = FindSum(999);
// Console.WriteLine(result);


//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


//усдовия выхода 

// void PrintNum ( int m, int n)
// {
//     if(n>=m)
//     {
//         PrintNum(m,n -1);
//         Console.WriteLine(n+" ");
//     }
//     else 
//     return;
// }

// PrintNum(4,8);

// void  numbersNM(int m, int n)
// {

//         if (m >= n)
//         {
//             numbersNM(m - 1, n);
//             Console.Write(m + " ");

//         }
//         else if((n >= m)) 
//         {
//             numbersNM(m, n - 1);
//             Console.Write(n + " ");

//         }
//         else return ;



// }
// int A = 4;
// int B = 7;
// numbersNM(A, B);


//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
int FindSum(int a, int b)
{
    if (b != 0)
    {

        return FindSum(a, b - 1) * a;
    }
    else return 1;
}
int result = FindSum(2, 4);
Console.WriteLine(result);


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine();

void numbers(int N)
{

    if (N > 0)
    {
        Console.Write(N + ", ");
        N--;
        numbers(N);
    }

}

Console.Write("Введите число N:   ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write("N = " + Num + " --> ");
numbers(Num);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("\n");

int SumNum(int m, int n)
{
    if (m <= n)
    {
        return SumNum(m + 1, n) + m;
    }
    else
        return 0;
}

Console.WriteLine(" Сумма : " + SumNum(1, 15));
Console.WriteLine(" Сумма : " + SumNum(4, 8));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akerman(int number, int argument)
{
    if (number == 0)
    {
        return argument + 1;
    }
    int result = argument;
    if (number > 0 && argument == 0)
    {
        return Akerman(number - 1, 1);
    }
    if (number > 0 && argument > 0)
    {
        return Akerman(number - 1, Akerman(number, argument - 1));

    }
    return result;
}


Console.WriteLine(Akerman(2, 3));
Console.WriteLine(Akerman(3, 2));
//Console.WriteLine(Akerman(2, 2));









