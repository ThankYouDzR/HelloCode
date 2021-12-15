// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] array = new int[123];
int n = array.Length;
int count = 0;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < n; i++){
    if(10<array[i] && array[i]<100){
        count++;
    }
}
Console.WriteLine($"Количество элементов из отрезка [10,99]: {count}");