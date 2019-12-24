using System;
using System.IO;
class StdIn {
    /*
    public static void Main(string[] args){
//        var stdin = System.Console.Read();
//        System.Console.WriteLine(stdin);

        string s;
        while ((s = Console.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }

    }
    */
    static void Main(string[] args)
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192))); // This will allow input >256 chars
        while (Console.In.Peek() != -1)
        {
            string input = Console.In.ReadLine();
            Console.WriteLine("Data read was " + input);
        }
    }
}
