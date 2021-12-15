// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int [] array = new int[13];
int n = array.Length;
int result = 0;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for(int i = 0; i<n; i++){
    int num1 = array[i];
    int num2 = array[n-1];
    result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
    n--;
    if((i>(n/2+1))){
        break;
    }
}