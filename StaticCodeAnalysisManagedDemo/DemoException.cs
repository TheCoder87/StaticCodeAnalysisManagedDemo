using System;
using System.Runtime.Serialization;

namespace CodeAnalysisManagedDemo
{
    public class DemoException : Exception
    {
        public DemoException()
            : base()
        {

        }

        public DemoException(string s)
            : base(s)
        {

        }

        public DemoException(string s, Exception e)
            : base(s, e)
        {

        }

        public DemoException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        public static void Initialize(int size)
        {

        }

        protected static readonly int _Item;

        public static int Item { get { return _Item; } }
    }
}