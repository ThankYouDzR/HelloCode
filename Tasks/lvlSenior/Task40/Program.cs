// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double [] array = new double[13];
int n = array.Length;
double result = 0;
double max = 0;
double min = 0;
for(int i = 0; i < n; i++){
    array[i] = Math.Round((new Random().NextDouble() + new Random().Next(1, 100)),3);
    Console.WriteLine(array[i]);
    max = array[0];
    min = array[0];
}
Console.WriteLine();
for(int i = 1; i < n; i++){
    if(array[i]>max){
        max = array[i];
    }
}    
for(int i = 1; i < n; i++){
    if(array[i]<min){
        min = array[i];
    }
}      
result = Math.Round((max - min),3);
Console.WriteLine($"Максимальное значение массива: {max}");
Console.WriteLine($"Минимальное значение массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max} - {min} = {result}");