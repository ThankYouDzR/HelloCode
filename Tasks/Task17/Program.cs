// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Please enter number: "); 
int Num1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Please enter number: "); 
int Num2 = int.Parse(Console.ReadLine()); 
if((Num1 == Math.Pow(Num2,2)) || (Num2 == Math.Pow(Num1,2)) ){
    Console.WriteLine("YES!");
}
else{
    Console.WriteLine("NO!");
}