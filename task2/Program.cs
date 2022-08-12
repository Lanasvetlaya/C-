class Program
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("Введите число а : ");
         int a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите число b : ");
         int b = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите число с : ");
         int c = Convert.ToInt32(Console.ReadLine());
         
          
         int maxd = a>b?a:b;
             maxd = maxd>c?maxd:c;            
 
          Console.WriteLine("{0};{1};{2} -> {3}",a,b,c,maxd);
         
        }
    }