using System;

namespace CodeAnalysisManagedDemo
{
    public class DemoException : Exception
    {
        public static void Initialize(int size)
        {

        }

        protected static readonly int _item;

        public static int Item { get { return _item; } }
    }
}