using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyProject
{
    public abstract class RowReader : IDisposable
    {
        public static Func<TextReader, RowReader> Create { get; protected set; }
        public abstract void Dispose();
        public abstract bool Read();
        public abstract T Get<T>(string name);
    }
}
