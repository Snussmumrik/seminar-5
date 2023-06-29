// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

// Метод для создания массива

int[] array = GetArray (10, 100, 1000);
Console.WriteLine (String.Join (" ", array));

// Метод для подсчета четных чисел в заданном массиве

int countNum = EvenNumbersCount(array);

//Вывод
Console.WriteLine ($" массив {array} содержит --> {countNum} четных чисел ");


// Задаем массив

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue);
    }
    return res;
}


// Считаем четные числа

int EvenNumbersCount(int[] arr)
{
int count = 0;

for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }  
    }
    return count;
}
