class Program
   /*
   Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        456 -> 5
        782 -> 8
        918 -> 1
   */
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите трехзначное число");
            string? digit = Console.ReadLine(); 
            digit = digit.Length==0?"0":digit;            
            
            string digit_s=Convert.ToString(Math.Abs(Convert.ToInt32(digit))); // Полученную строку конвертим в число берем моуль и конвертим обратно в строку . Для обработки чисел <0 
           if (digit_s.Length==3) // Проверяем что число трехзначное  
            {
              Console.WriteLine($"{digit}->{digit_s[1]}");
            }
           else
            {
               Console.WriteLine("Число должно быть трехзначным");
               return;
            }
        }
    }
 
