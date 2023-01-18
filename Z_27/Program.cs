/*   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12  */

Console.Clear();

int getUserValue(string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int num = getUserValue("Введите число: ");


int SumNumber(int num)
    {    
        int counter = (num / 10);
        int advance = 0;
        int result = 0;

        for (int i = 0; i < counter; i++)
            {
                advance = num - num % 10;
                result = result + (num - advance);
                num = num / 10;
            }
        return result;
    }


int sumNumbersDigit = SumNumber (num);

void stringMassage (int array)
    {   
        Console.Write("[");

        for (int i = 0; i < 1; i++)
        {
            Console.Write($"Сумма цифр числа {num} равна {sumNumbersDigit}");
        }    

        Console.Write("]");
    }

int array = SumNumber (num);
stringMassage(array);