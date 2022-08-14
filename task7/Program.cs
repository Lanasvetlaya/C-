class Program
   /*  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
           6 -> да
           7 -> да
           1 -> нет
   */
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите цифру, обозначающую день недели");
         Console.WriteLine("1-Пн 2-Вт 3-Ср 4-Чт 5-Пт 6-Сб 7-Вс");
            int NumberOfWeekDay = Convert.ToInt32(Console.ReadLine()); 
            string[] WeekDay = {"ПН,нет","ВТ,нет","СР,нет","ЧТ,нет","ПТ,нет","СБ,да","ВС,да"};
            Console.WriteLine($"{NumberOfWeekDay}->{WeekDay[NumberOfWeekDay-1]}");
            
        }
    }