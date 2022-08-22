// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreatArrayRundInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int SumEvenInd(int[] array)
{
    int sumEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0) sumEven += array[i+1];
    }
    return sumEven;
}

int[] arr = CreatArrayRundInt(6, -99, 100);
PrintArray(arr);
int res = SumEvenInd(arr);
Console.Write("-->"+res);




