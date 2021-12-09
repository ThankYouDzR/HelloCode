// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int result = 1;
for(int i = 1; i <= N; i++)
{
    result = result * i;
}
Console.Write("Произведения чисел от 1 до " + N + " = " + result);