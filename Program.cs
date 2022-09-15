string[] array = new string[] { "hello", "2", "world", ":-)", "123", "каша" };
string[] resArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resArray[i] = array[i];
    }
}


