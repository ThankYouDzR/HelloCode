// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number);
if(number<100){
    Console.WriteLine("Третьей цифры нет");
}
else{
    while(number>1000){
        number = number/10;
    }
    Console.WriteLine("Третья цифра в числе: " + (number%10));
}