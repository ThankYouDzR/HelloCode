// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("Please enter X true or false: "); 
bool X = bool.Parse(Console.ReadLine()); 
Console.WriteLine("Please enter Y true or false: "); 
bool Y = bool.Parse(Console.ReadLine()); 
if((!(X||Y)) == (!X && !Y)){
    Console.WriteLine("All right!");
}
else{
    Console.WriteLine("Error!");
}