using MyProject.CsvHelper;
using MyProject.Users;
using System;
using static System.Console;

namespace MyProject.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvRowReader.Use();

            var text = "First,Last\nJohn,Doe\n";
            var file = NameFile.Parse(text);
            foreach (var n in file)
                WriteLine($"{n.First} {n.Last}");
        }
    }
}
