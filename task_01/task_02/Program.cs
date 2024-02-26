// Задание 2. Работа в сессионных залах
// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// амените отрицательные элементы на положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

using System.Runtime.Serialization.Formatters;

int[] array = new int[10] { -5, 6, -7, 8, -9, 1, 3, -2, 12, -10 };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)

{
    array[i] *= -1;
}


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]} ");
}