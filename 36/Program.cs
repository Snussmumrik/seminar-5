//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

// Метод для создания массива

int[] array = GetArray (10, 10, 100);
Console.WriteLine (String.Join (" ", array));

// Метод для подсчета суммы чисел, стоящих на нечетных позициях

int sumNumbers = OddNumbersCount(array);

//Выводим результат

Console.WriteLine ($" сумма элементов на нечетных позициях  --> {sumNumbers} ");

// Считаем сумму чисел, стоящих на нечетных позициях

int OddNumbersCount(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length;)
    {
        if (i % 2 != 0);
        {
            sum += arr[i];
            i = i + 2;
        }
    }
    return sum;
}


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