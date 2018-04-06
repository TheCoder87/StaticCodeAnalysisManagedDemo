using System;
using System.Runtime.Serialization;

namespace CodeAnalysisManagedDemo
{
    [Serializable()]
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

        private static readonly int item;

        public static int Item { get { return item; } }
    }
}