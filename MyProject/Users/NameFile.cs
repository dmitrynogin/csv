using MyProject.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Users
{
    public class NameFile : RowFile<NameFile, FullName>
    {
        protected override IEnumerable<FullName> Read(RowReader reader)
        {
            while (reader.Read())
                yield return new FullName
                {
                    First = reader.Get<string>("First"),
                    Last = reader.Get<string>("Last")
                };
        }
    }
}
