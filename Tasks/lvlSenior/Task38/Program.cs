// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] array = new int[11];
int n = array.Length;
int sum = 0;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < n; i++){
    if(i%2 == 0){
        sum = sum + array[i];
    }    
}
Console.WriteLine($"Cумма чисел одномерного массива стоящих на нечетной позиции: {sum}");