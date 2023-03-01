Console.Clear();

ListArrays();

void ListArrays()
{
    Console.WriteLine();
    Console.WriteLine("СПИСОК МАССИВОВ:");
    Console.WriteLine("1ый массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2ой массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3ий массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

string? InputArray(string cmd)
{
    Console.Write(cmd);
    return Console.ReadLine();
}

string[] array = new string[] { };
string? arrayCases = InputArray("Выберите массив: ");
switch (arrayCases)
{
    default:
        Console.WriteLine($"{arrayCases} - Такого массива нет.");
        break;
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
}

string[] NewArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"“{array[i]}”, ");
        else Console.Write($"“{array[i]}”");
    }
    Console.Write("]");
}

PrintArray(array);
Console.Write(" -> ");
string[] newArray = NewArray(array);
PrintArray(newArray);