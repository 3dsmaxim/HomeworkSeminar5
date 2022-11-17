Console.Clear();



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] Array(int num)
{
    double[] arr = new double[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble()* 100,3);
        // arr[i] = new Random().Next(-100, 100 );
    }
    return arr;
}

void SumIndexNum(double[] arrayNum)
{
    
    double sumA = arrayNum[0];
    double sumB = arrayNum[0];
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (arrayNum[i] < sumA) sumA = arrayNum[i];
        if (arrayNum[i] > sumB) sumB = arrayNum[i];

    }
    sumA = sumB - sumA;
    Console.Write($" разница между большим и меньшим элементом массива равна {sumA}");
}

Console.WriteLine("Введите размерность массива");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = Array(number);

Console.Write($"массив [ {String.Join("| ", array)} ]");
SumIndexNum(array);

// Так пока и не понял как выглядят вещественные числа.