using System;

class Sunglasses
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number N:");
        int N = int.Parse(Console.ReadLine());
        string frame = new string('*', N * 2);
        string lenses = new string('/', N * 2 - 2);
        string bridge = new string('|', N);
        string space = new string(' ', N);
        string secondSpace = new string(' ', N * 2 - 2);       
       
            Console.WriteLine("{0}{1}{2} ", frame, space, frame);

               for (double j = 0; j <= ((N - 2)/2-0.5); j++)
                  {
                      Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", '*', lenses, '*', space, '*', lenses, '*');  
                  }
               Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", '*', lenses, '*', bridge, '*', lenses, '*');       
               for (double k = 0; k <= ((N - 2)/2-0.5); k++)
                  {
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", '*', lenses, '*', space, '*', lenses, '*');
                  }
            Console.WriteLine("{0}{1}{2} ", frame, space, frame);        
    }
}
  
