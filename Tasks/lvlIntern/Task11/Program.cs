// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,100);
Console.WriteLine("Случайное число: " + number);
int first = number/10;
int second = number%10;
if(first>=second)
{
    Console.WriteLine("Наибольшая цифра числа: " + first);
}
else
{
    Console.WriteLine("Наибольшая цифра числа: " + second);
}