using System;

    class ASCII
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII value" + "\tCharacter");
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine ("   "+i+"\t  ----->"+"    {0}",(char)i);
            }
        }
    }

