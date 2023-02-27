void PrintArray (string [] array)
{
    Console.Write("[");
    if(array.Length == 0) Console.Write("]");
    else
    {    
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length - 1]}]");
    }
}

string [] FindElementLess3Char (string [] array)
{
    string temp = String.Empty; 
    string [] rezultArray = new string [0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            temp = temp + array[i] + " ";
    }

    if(temp != String.Empty)
    {
        rezultArray = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }

    return rezultArray;
}

string [] startArray = {"1234", "1567", "-2456", "computer science"};
PrintArray(startArray);
string [] rezultArray = FindElementLess3Char(startArray);
Console.Write(" -> ");
PrintArray(rezultArray);
