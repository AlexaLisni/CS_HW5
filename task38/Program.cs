// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($" {array[i]}. ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write(" ]");
}

double MaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max <= arr[i]) max = arr[i];
        else if(min >= arr[i]) min = arr[i];
    }
    double res = max-min;
    return res;
}


double[] array = {3.5, 7.1, 22.9, 2.3, 78.5};
PrintArray(array);
double result = MaxMin(array);
Console.Write(result);

