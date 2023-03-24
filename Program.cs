void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine();
}

string[] filterArray(string[] array) {
    int newArraySize = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length < 4)
            newArraySize++;

    string[] result = new string[newArraySize];

    int indexNew = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length < 4) {
            result[indexNew] = array[i];
            indexNew++;
        }

    return result;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0) {
    string[] array = new string[size];
    for(int i = 0; i < size; i++) {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }

    string[] newArray = filterArray(array);

    Console.WriteLine("Новый массив");
    ShowArray(newArray);
} else {
    Console.WriteLine("Количество элементов должно быть целым положительным числом");
}
