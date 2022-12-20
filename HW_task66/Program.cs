// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int numberM = ReadInt("Введите M: ");
int numberN = ReadInt("Введите N: ");
Console.WriteLine(SumOfElements(numberM ,numberN));

if (numberM > numberN)
  Console.Write("Рассчитать сумму невозможно"); 

int SumOfElements(int m, int n)
{   
    if (m == n)
      return m;
    else
    {
      return m + SumOfElements(m+1,n);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

