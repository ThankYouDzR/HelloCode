// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] array = new int[10];
int n = array.Length;
int count1 = 0;
int count2 = 0;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < n; i++){
    if(array[i]%2==1){
        count1++;
    }
    else{
        count2++;
    }    
}
Console.WriteLine($"Количество нечетных чисел: {count1}");
Console.WriteLine($"Количество четных чисел: {count2}");