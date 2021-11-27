// Найти максимальное из трех чисел

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int third = Convert.ToInt32(Console.ReadLine());
int max = first;
if(second > max) max = second;
if(third > max) max = third;
Console.WriteLine("Максимальное число = " + max);