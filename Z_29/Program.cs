/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.Clear();

int getNumUser(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int number = getNumUser("Введите количество элементов массива");

int [] Fullarray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
int[] array = Fullarray(number, -100, 100);

void stringMassage (int []array)
    {   Console.Write("[");

        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array [j] + ",");
               
        }
        
        Console.Write("\b");

        Console.Write("]");

    }
    stringMassage(array);
