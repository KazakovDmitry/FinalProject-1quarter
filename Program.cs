void PrintArray (string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

string [] FindElementLess3Char (string [] array)
{
    string temp = String.Empty;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i].Length <= 3)
            temp = temp + array[i] + " ";
    }
    temp = temp + array[array.Length - 1];

    string [] rezultArray = temp.Split(" ");

    return rezultArray;
}

string [] startArray = {"hello", "2", "world", ":-)"};
PrintArray(startArray);
string [] rezultArray = FindElementLess3Char(startArray);
Console.Write(" -> ");
PrintArray(rezultArray);
