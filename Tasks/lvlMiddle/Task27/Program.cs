// Определить количество цифр в числе

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int count = 0;
while(numb>0){
    numb = numb/10;
    count++;
}
Console.Write("В этом числе " + count + " цифр");


