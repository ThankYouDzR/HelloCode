// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите значение A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение B");
int B = int.Parse(Console.ReadLine());
int result = 1; 
for(int i = 1; i <=B; i++)
{
    result = result * A;
}
Console.Write("Ответ: " + result);