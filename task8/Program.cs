
    class Program
   /* Задача 19
      Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
      14212 -> нет
      12821 -> да
      23432 -> да
   */
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите пятизначное число :");
            string? digit = Console.ReadLine(); 
            digit = digit.Length==0?"0":digit; // проверка на пустой ввод             
            string digit_s=Convert.ToString(Math.Abs(Convert.ToInt32(digit))); // Полученную строку конвертим в число берем моуль и конвертим обратно в строку . Для обработки чисел <0 
           if (digit_s.Length==5) // Проверяем что число 5и значное    
            {
              char[] reverse_dgt = digit_s.ToCharArray(); // Разложим на символы строку полученную из числа 
              Array.Reverse(reverse_dgt); // Переставим в массиве все символы задом - на перед 
              string rev_sting = new string(reverse_dgt); // Из посимвольного массива запишем в строку наш "перевертыш"
              if(digit_s==rev_sting)
                {
                  Console.WriteLine($"{digit} -> да");
                }
              else
                {
                  Console.WriteLine($"{digit} -> нет");
                }
            }
           else
            {
               Console.WriteLine($"{digit}->Ошибка ! Введите 5и значное число ");
               return;
            }
        }
    }
