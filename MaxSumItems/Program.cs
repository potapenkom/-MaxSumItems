using System;

namespace MaxSumItems
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter Path");
                var path = @"" + Console.ReadLine();
                UserFile userFile = new UserFile(path);
                Reader reader = new Reader(userFile);
                reader.Read();

            }
            foreach (var path in args)
            {
                UserFile userFile = new UserFile(path);
                Reader reader = new Reader(userFile);
                reader.Read();
            }

        }
    }
}
