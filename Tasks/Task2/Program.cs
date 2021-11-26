Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
if(first > second)
{
    Console.WriteLine("Наибольшее число = " + first + " Наименьшее число = " + second);
}
else
{
    Console.WriteLine("Наибольшее число = " + second + " Наименьшее число = " + first);
}
