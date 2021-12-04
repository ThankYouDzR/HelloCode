// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Please enter X (X != 0): "); 
int X = int.Parse(Console.ReadLine()); 
Console.WriteLine("Please enter Y (Y != 0): "); 
int Y = int.Parse(Console.ReadLine()); 
if(X>0){
    if(Y>0){
        Console.WriteLine("first quarter");
    }
    else{
        Console.WriteLine("fourth quarter");
    }
}
else{
    if(Y>0){
        Console.WriteLine("second quarter");
    }
    else{
        Console.WriteLine("third quarter");
    }
}