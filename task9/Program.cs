
    class Program
   /* Задача 21
       Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
       A (3,6,8);   B (2,1,-7),  -> 15.84
       A (7,-5, 0); B (1,-1,9) -> 11.53
   */
    {
        static void Main(string[] args)
        {
           float [,] ArrayCoord = new float [2,3]; // Обявили мерный массив размерностью 2х3 
             
           Console.WriteLine("Введите X координату точки A :");
           ArrayCoord[0,0]=(float)Convert.ToDouble(Console.ReadLine()); 
           Console.WriteLine("Введите Y координату точки A :");
           ArrayCoord[0,1]=(float)Convert.ToDouble(Console.ReadLine()); 
           Console.WriteLine("Введите Z координату точки A :");
           ArrayCoord[0,2]=(float)Convert.ToDouble(Console.ReadLine()); 
           Console.WriteLine("Введите X координату точки B :");
           ArrayCoord[1,0]=(float)Convert.ToDouble(Console.ReadLine()); 
           Console.WriteLine("Введите Y координату точки B :");
           ArrayCoord[1,1]=(float)Convert.ToDouble(Console.ReadLine()); 
           Console.WriteLine("Введите Z координату точки B :");
           ArrayCoord[1,2]=(float)Convert.ToDouble(Console.ReadLine()); 
 
           // Рассчет длины отрезка в 3d
           double reslt=(double)(Math.Sqrt(Math.Pow(ArrayCoord[1,0]-ArrayCoord[0,0],2) + Math.Pow(ArrayCoord[1,1]-ArrayCoord[0,1],2)+Math.Pow(ArrayCoord[1,2]-ArrayCoord[0,2],2)));
           reslt= Math.Round(reslt, 2);// Округлим до 2 го знака 
           Console.WriteLine($"A ({ArrayCoord[0,0]} , {ArrayCoord[0,1]} , {ArrayCoord[0,2]}); B({ArrayCoord[1,0]} , {ArrayCoord[1,1]} , {ArrayCoord[1,2]}) -> {reslt}");
         
        }
    }
