int m = InputNum("Введите длину массива ");

int[] array = CreateArray(m);
PrintArray(array, "Базовый массив");

int num = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        num++;
    }
}

System.Console.WriteLine($"Количество значений больше 0 = {num}");

int[] CreateArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNum("Введите числа через Enter ");                                         
    }
    return array;
}

void PrintArray(int[] array, string msg)
{
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int InputNum(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}