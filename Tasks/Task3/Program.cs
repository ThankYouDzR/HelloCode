Console.WriteLine("Введите номер дня недели");
int numberDay = Convert.ToInt32(Console.ReadLine());
if(numberDay == 1)
{
    Console.WriteLine("monday");
}
if(numberDay == 2)
{
    Console.WriteLine("tuesday");
}
if(numberDay == 3) 
{
    Console.WriteLine("wednesday");
}
if(numberDay == 4)
{
    Console.WriteLine("thursday");
}
if(numberDay == 5)
{
    Console.WriteLine("friday");
};
if(numberDay == 6) 
{
    Console.WriteLine("saturday");
}
if(numberDay == 7)
{
    Console.WriteLine("sunday");
}
else
{    
    Console.WriteLine("Invalid number");
}    