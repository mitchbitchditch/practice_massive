// Задание 4*. Совместная работа
// [если позволит тайминг]
// Дано натуральное трёхзначное число. Создайте массив, 
// состоящий из цифр этого числа. Младший разряд числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456  =>  [6 5 4]
// 781  =>  [1 8 7]

//Примеры массивов
// int[] array0 = new int[8];
// int[] array1 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array = { 5, 6, 7, 8, 9, 10 };


Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

int i = 0;

if (num < 0)
{
    Console.WriteLine("введено отрицательное число");
    return;
}

if (num > 999 || num < 100) 
{
    Console.WriteLine("Введено не трехзначное число");
    return;
}


while (num > 0)
{
    array[i] = num % 10;
    i = i + 1;
    num = num / 10;
}


for (int j = 0; j < array.Length; j++)
{
    Console.Write($"{array[j]} ");
}
