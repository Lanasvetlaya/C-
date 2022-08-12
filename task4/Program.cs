class Program
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("Введите число : ");
         int a = Convert.ToInt32(Console.ReadLine());
         string result="";
        for (int count =1 ; count!=a+1; count++) 
         {
          if (count%2!=1) 
          {
            if (count>2 && a%2==1) result=result+",";
            if (count>3 && a%2!=1) result=result+",";    
            result=result+count.ToString();
            
          }
          
         }
         
         Console.WriteLine("Число {0} -> {1}",a,result);
         
        }
    }