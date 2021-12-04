// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Please enter number 1-7: "); 
int Num = int.Parse(Console.ReadLine()); 
if (Num % 6 == 0 || Num %7 == 0){
    Console.WriteLine("Yes, it's a day off!"); 
}
else{
    Console.WriteLine("No, it's a weekday");
}