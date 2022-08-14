class Program
   /*
   Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
   */
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите число");
            string? digit = Console.ReadLine(); 
            digit = digit.Length==0?"0":digit;            
            
            string digit_s=Convert.ToString(Math.Abs(Convert.ToInt32(digit))); // Полученную строку конвертим в число берем моуль и конвертим обратно в строку . Для обработки чисел <0 
           if (digit_s.Length>=3) // Проверяем что число не менее чем 3х значное    
            {
              Console.WriteLine($"{digit}->{digit_s[2]}");
            }
           else
            {
               Console.WriteLine($"{digit}->третьей цифры нет");
               return;
            }
        }
    }
