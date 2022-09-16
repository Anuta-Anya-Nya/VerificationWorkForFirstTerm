string[] FillArray(int size)
{
    string[] anyArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        anyArray[i] = Console.ReadLine()!;
    }
    return anyArray;
}

Console.Write("Введите длину массива: ");
if (!int.TryParse(Console.ReadLine(), out int sizeArray))
{
    Console.WriteLine("Введено не число!");
    return;
}
string[] array = FillArray(sizeArray);
string[] FilterArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArr = new string[count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}
string[] newArray = FilterArray(array);
Console.WriteLine($"Введенный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");
