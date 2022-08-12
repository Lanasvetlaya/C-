   class Program
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("Введите число : ");
         int a = Convert.ToInt32(Console.ReadLine());
         
         string res = a%2==1?"Нет":"Да";
         
         Console.WriteLine("Число {0} -> {1}",a,res);
         
        }
    }
