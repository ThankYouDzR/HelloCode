// Определить, присутствует ли в заданном массиве, некоторое число

int [] array = new int[7];
int n = array.Length;
bool flag = false;
for(int i = 0; i < n; i++){
    array[i] = new Random().Next(0, 11);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
Console.Write("Введите искомое число: ");
int find = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++){
    if(array[i] == find){
        flag = true;
        break;
    }
}
if(flag){
    Console.WriteLine($"Число {find} присутствует в массиве");
}
else{
    Console.WriteLine($"Число {find} не присутствует в массиве");
}