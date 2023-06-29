//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

// Метод для создания массива

double[] array = GetArray (10, 10, 100);
Console.WriteLine (String.Join (" ", array));

// Метод для нахождения наибольшего значения
double max = MaxValue(array);
Console.WriteLine ($" {max} ");

// Метод для нахождения наибольшего значения
double min = MinValue(array);
Console.WriteLine ($" {min} ");

//Вывод результата
Console.WriteLine ($" {max - min} ");



// Создаем массив
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double [size];

    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().NextDouble();
    }
    return res;
}


//находим наибольшее значение
double MaxValue(double[] arr)

{
     double[] resultMax = arr[i]]

    for (int i = 0; i < arr.Length; i++,)
    {
        if(arr[i] < resultMax)
        {
            resultMax = arr[i];
        }
    }
    return resultMax;
}


//находим наименьшее значение
double MinValue(double[] arr)

{
     double[] resultMin = arr[i]

    for (int i = 0; i > arr.Length; i++,)
    {
        if(arr[i] > resultMin)
        {
            resultMin = arr[i];
        }
    }
    return resultMin;
}




