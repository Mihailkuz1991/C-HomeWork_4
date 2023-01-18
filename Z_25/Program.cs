/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16      */

Console.Clear();

int getUserValue(string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int A = getUserValue("Введите число A");
int B = getUserValue("Введите число B");

int StepNum(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
        {
           result = result * A;
        }
    return result;
}

int Stepen = StepNum (A, B); 

void stringMassage (int array)
    {   
        Console.Write("[");

        for (int j = 0; j < 1; j++)
        {
            Console.Write($"Число {A} в степени {B} будет равно {Stepen}");
        }    

        Console.Write("]");
    }

int array = StepNum(A, B);
stringMassage(array);