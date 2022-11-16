Console.Clear();

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] NewArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

void SumIndexNum(int[] arrayNum)
{
    int sum = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (i % 2 != 0) sum += arrayNum[i];

    }
    Console.Write($" сумма элементов, стоящих на нечётных позициях равен {sum}");
}

Console.WriteLine("Введите размерность массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(number);

Console.Write($"массив [{String.Join(" ,", array)}]");
SumIndexNum(array);