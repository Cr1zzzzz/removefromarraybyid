class Program
{
    static void Main()
    {
        int[] array = new int[5];

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }

        Console.WriteLine("Array before");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.Write("\nEnter id:\n");
        int index = Convert.ToInt32(Console.ReadLine()); ;
        Console.Write("Enter value:\n");
        int elementToAdd = Convert.ToInt32(Console.ReadLine()); ;
        int[] newArray = new int[array.Length - 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }


        for (int i = index; i < newArray.Length; i++)
        {
            newArray[i] = array[i + 1];
        }

        Console.WriteLine("\nArray after");
        foreach (var item in newArray)
        {
            Console.Write(item + " ");
        }
    }
}