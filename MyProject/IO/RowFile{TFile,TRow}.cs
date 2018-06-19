using MyProject.ComponentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyProject.IO
{
    public abstract class RowFile<TFile, TRow> : Enumerable<TRow>
        where TFile : RowFile<TFile, TRow>, new()
    {
        public static readonly TFile Empty = new TFile();

        public static TFile Parse(string text) =>
            Load(new StringReader(text));

        public static TFile Load(string filePath) =>
            Load(File.OpenText(filePath));

        public static TFile Load(Stream stream) =>
            Load(new StreamReader(stream));

        public static TFile Load(TextReader reader)
        {
            var file = new TFile();
            file.Rows = file.Read(RowReader.Create(reader));
            return file;
        }

        public sealed override IEnumerator<TRow> GetEnumerator() =>
            Rows.GetEnumerator();

        protected abstract IEnumerable<TRow> Read(RowReader read);
        IEnumerable<TRow> Rows { get; set; } = new TRow[0];
    }
}
