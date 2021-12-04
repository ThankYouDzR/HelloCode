// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int number1 = new Random().Next(1,1001);
Console.WriteLine("Делимое число: "+ number1);
Console.WriteLine("Введите число-делитель:");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 % number2;
if((number1 % number2) == 0)
{
    Console.WriteLine("Число кратно заданному");
}
else
{
    Console.WriteLine("Остаток от деления = " + (number1%number2));
}