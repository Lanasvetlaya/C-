class Program
    {
        static void Main(string[] args)
      {
         
         Console.WriteLine("Введите число а : ");
         int a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите число b : ");
         int b = Convert.ToInt32(Console.ReadLine());
         
          
         int maxd = a>b?a:b;   
 
          Console.WriteLine("a = {0};b = {1} -> max = {2}",a,b,maxd);
         
        }
    }
 

 