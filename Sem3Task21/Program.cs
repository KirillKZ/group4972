// №21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

 double Length(int[] pointA, int[] pointB)
    {
     return Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));

    }
    int[] pointA = new int[]{3,6,8}; 
    int[] pointB = new int[]{2,1,-7}; 
    
    System.Console.WriteLine(Length(pointA, pointB));