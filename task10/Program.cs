
    class Program
   /* Задача 23
      Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
       3 -> 1, 8, 27
       5 -> 1, 8, 27, 64, 125
   */
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите целое число >0 :");
           int N =Convert.ToInt32(Console.ReadLine()); 
           string result ="";
            for (int i = 1; i < N+1; i++)
             {
             result =result+Convert.ToString(Math.Pow(i,3));
             if (i!=N)
             {
                result =result+" , ";
             } 
             } 
           Console.WriteLine($"{N} -> {result}");
         
        }
    }
 

