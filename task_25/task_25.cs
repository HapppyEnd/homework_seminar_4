//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int res = 1;

int Result(int a, int b)
{
    for (int i = 0; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

int A = InputNumber("Введите число № 1: ");
int B = InputNumber("Введите число № 2: ");
System.Console.WriteLine(Result(A, B));