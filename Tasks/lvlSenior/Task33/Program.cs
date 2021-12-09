// Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

int [] array = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
int n = array.Length;
int sum1 = 0;
int sum2 = 0;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < n; i++){
    if(array[i] >= 0){
        sum1 = sum1 + array[i];
    }
    else{
        sum2 = sum2 + array[i];
    }
}
Console.WriteLine("Сумма положительных элементов = " + sum1);
Console.WriteLine("Сумма отрицательных элементов = " + sum2);