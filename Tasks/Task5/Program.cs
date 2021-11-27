// Написать программу вычисления значения функции y = f(a)
// График кубической функции (кубическая парабола): y = ax3 + bx2 + cx + d
// y = 3x3 + 7x2 + 14x - 10

Console.WriteLine("Введите значение x");
int x = Convert.ToInt32(Console.ReadLine());
double y = 3 * Math.Pow(x, 3) + 7 * Math.Pow(x, 2) + 14 * x - 10;
Console.WriteLine("Значение функции: y = " + y);
