using System;
using System.Collections.Generic;
using System.Text;

namespace TS.MediatR
{
    public readonly struct Unit
    {
        public static readonly Unit Value = new();
    }
}
