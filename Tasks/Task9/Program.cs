// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100 ^ number > 999)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    Console.WriteLine(number % 10);
}