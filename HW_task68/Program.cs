// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");

Console.WriteLine(AkkermanNumber(m, n));

int AkkermanNumber(int m, int n)
{
   if (m < 0 || n < 0)
   {
      Console.Write("The numbers are negative");
      return 0;
   }

   if (m == 0)
   {
      return n+1;
   }
   else 
   {
      if(n == 0)
      {
         return AkkermanNumber(m - 1, 1);
      }
      else
      {
         return AkkermanNumber(m - 1, AkkermanNumber(m, n - 1));
      }
   }   
}

int ReadInt(string message)
{
   Console.Write(message);
   return int.Parse(Console.ReadLine());
}