﻿// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Please enter quarter number 1-4: "); 
int num = int.Parse(Console.ReadLine());
if(num == 1){
    Console.WriteLine("X>0 Y>0");
}
if(num == 2){
    Console.WriteLine("X<0 Y>0");
}
if(num == 3){
    Console.WriteLine("X<0 Y<0");
}
if(num == 4){
    Console.WriteLine("X>0 Y<0");
}