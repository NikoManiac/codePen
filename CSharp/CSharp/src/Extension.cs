using System.Collections.Generic;

namespace CSharp
{
    public static class Extension
    {
        public static int WordCount(this string str)
        {
            return str.Length;
        }

        public static int WordConvert(this string str, int exLength)
        {
            return str.Length + exLength;
        }
        
        public static string WordConvert(this string str, string exStr)
        {
            return $"{str}, {exStr}";
        }

        public interface ITest
        {
            void YTest();
        }
        
        public static int ListLength(this List<ITest> list)
        {
            return list.Count + 1;
        }
    }
}