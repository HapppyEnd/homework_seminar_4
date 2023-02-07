//  Задача 29: Напишите программу, которая задаёт массив 
//  из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[] NumArray(int size, int first, int last)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(first, last + 1);
    }
    return arr;
}

int InputNumber(string text)
{
    System.Console.WriteLine(text);

    return Convert.ToInt32(Console.ReadLine());
}

int a = InputNumber("Введите длину массива: ");
int b = InputNumber("Введите число № 1: ");
int c = InputNumber("Введите число № 2: ");


System.Console.WriteLine("[{0}]", string.Join(", ", NumArray(a, b, c)));