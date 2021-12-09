// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int result = 0;
int sum = 0;
while(numb > 0){
    result = numb % 10;
    numb = numb / 10;
    sum = sum + result;
}
Console.Write("Сумма цифр этом числе = " + sum);