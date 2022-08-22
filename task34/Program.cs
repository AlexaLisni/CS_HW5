// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int EvenNum(int[] array)
{
    int sumEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sumEven++;
    }
    return sumEven;
}

int[] arr = CreatArrayRundInt(5, 100, 1000);
PrintArray(arr);
int res = EvenNum(arr);
Console.Write("-->"+res);

