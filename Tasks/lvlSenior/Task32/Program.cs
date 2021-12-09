// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int [] array = {0, 0, 0, 0, 0, 0, 0, 0};
int n = array.Length;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]+" ");
}