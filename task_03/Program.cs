// Задание 3. Совместная работа
// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// Примеры массивов
// int[] array0 = new int[8];
// int[] array1 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array = { 5, 6, 7, 8, 9, 10 };


int[] array = { 1, 3, 2, 4, 2, 3 };
int[] array2 = { 2, 3, 1, 7, 5, 6, 3 };
int[] newArray = new int[array.Length / 2];


for (int i = 0; i < array.Length; i++)

    Console.Write(array[i] + " ");


for (int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

Console.WriteLine();

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"{newArray[i]} ");
}
