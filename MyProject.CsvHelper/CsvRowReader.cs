using CsvHelper;
using System;
using System.IO;

namespace MyProject.CsvHelper
{
    public class CsvRowReader : RowReader
    {
        public static void Use() =>
            Create = reader => new CsvRowReader(reader);

        CsvRowReader(TextReader reader)
        {
            Reader = new CsvReader(reader);
            Reader.Read();
            Reader.ReadHeader();
        }

        CsvReader Reader { get; }

        public override void Dispose() =>
            Reader.Dispose();

        public override bool Read() =>
            Reader.Read();

        public override T Get<T>(string name) =>
            Reader.GetField<T>(name);
    }
}
