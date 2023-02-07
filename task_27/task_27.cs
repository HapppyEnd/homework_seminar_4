//  Задача 27: Напишите программу, которая принимает на вход число и 
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string? InputNumbers(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}


string? number_1 = InputNumbers("Введите число: ");

int[] SumNum()
{
    int[] arr = new int[number_1!.Length];
    for (int i = 0; i < number_1.Length; i++)
    {
        arr[i] = Convert.ToInt32(number_1[i].ToString());
    }
    return arr;
}
System.Console.WriteLine($"Сумма цифр в числе {number_1} равна {SumNum().Sum()}.");