﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemcachedSharp
{
    [Serializable]
    public sealed class MemcachedException : Exception
    {
        private MemcachedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        internal MemcachedException(string message)
            : base(message)
        {
        }
    }
}