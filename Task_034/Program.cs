Console.Clear();


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int l)
{
    int[] arr = new int[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}



void Counter(int[] arrayCount)
{
int count = 0;
for (int i = 0; i < arrayCount.Length; i++)
{
    if (arrayCount[i] % 2 == 0) count++;
}
Console.WriteLine($" в массиве колличество четных чисел равно {count}");
}



Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray(num);

Console.Write($"массив [{String.Join(" ,", array)}]");
Counter(array);



