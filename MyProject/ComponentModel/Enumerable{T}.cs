﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace MyProject.ComponentModel
{
    public abstract class Enumerable<T> : IEnumerable<T>
    {
        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
    }
}
