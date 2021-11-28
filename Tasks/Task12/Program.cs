// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int first = number/100;
int second = number%10;
if(number <100 ^ number > 999)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    Console.WriteLine(Convert.ToString(first)+Convert.ToString(second));
}