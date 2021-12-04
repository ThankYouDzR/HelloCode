// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Please enter number: "); 
int Num = int.Parse(Console.ReadLine()); 
if (Num % 7 == 0 || Num %23 == 0){
    Console.WriteLine("Number is divisible by 7 or 23"); 
}
else{
    Console.WriteLine("Number is not divisible by 7 or 23");
}