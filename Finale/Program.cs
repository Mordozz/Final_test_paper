class Program
{
    static void Main()
    {
        string[] originalArray = { "Hello", "2", "world", ":-)" };
        List<string> newList = new List<string>();

        for (int i = 0; i < originalArray.Length; i++)
        {
            
            if (originalArray[i].Length <= 3)
            {
                newList.Add(originalArray[i]);
            }
        }

        string[] newArray = newList.ToArray();

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
