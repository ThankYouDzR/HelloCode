// Найти расстояние между точками в пространстве 2D/3D
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Please enter Xa: "); 
int Xa = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Ya: "); 
int Ya = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Za: "); 
int Za = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Xb: "); 
int Xb = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Yb: "); 
int Yb = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Zb: "); 
int Zb = int.Parse(Console.ReadLine());
double quatro = Math.Pow((Xb-Xa),2) + Math.Pow((Yb-Ya),2) + Math.Pow((Zb-Za),2);
double result = Math.Sqrt(quatro);
Console.WriteLine("AB = "+result);