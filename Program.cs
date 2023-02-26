void PrintArray (string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}


string [] startArray = {"hello", "2", "world", ":-)"};
PrintArray(startArray);
