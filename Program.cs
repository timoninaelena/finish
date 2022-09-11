string[] FirstString(string[] stringArray)
{
    int count = stringArray.Length;
    string[] newStringArray = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}
void PrintArray(string[] array)
{
    string text = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] array = new string[] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science","Russia", "Denmark", "Kazan" };
string[] NewArray = FirstString(array);
PrintArray(NewArray);