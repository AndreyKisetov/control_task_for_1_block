namespace HelloWorld
{
    // Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
    class Program
    {
        static void Main()
        {
            Console.Clear();
            string[] stringArray = new string[] { "hello", "2", "world", ":-)" };
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (3 >= stringArray[i].Length)
                {
                    Console.Write(stringArray[i] + "  ");
                }
            }
            Console.WriteLine();
        }
    }
}
