// Написать программу замену элементов массива на противоположные

int [] array = new int[7];
int n = array.Length;
int sum1 = 0;
int sum2 = 0;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < n; i++){
    array[i] = array[i] * (-1);
    Console.Write(array[i]+" ");
}    
