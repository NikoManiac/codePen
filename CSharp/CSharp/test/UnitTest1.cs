using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace CSharp
{
    public class UnitTest1
    {
        [Fact]
        public void should_get_string_length_by_extension()
        {
            const string str = "abc";
            Assert.Equal(3, str.WordCount());
        }

        [Fact]
        public void should_get_ex_length_for_string()
        {
            const string str = "abc";
            Assert.Equal(5, str.WordConvert(2));
        }

        [Fact]
        public void should_get_ex_string_for_string()
        {
            const string str = "abc";
            Assert.Equal("abc, 1", str.WordConvert("1"));
        }

        [Fact]
        public void should_get_test_list_length()
        {
            var a = new MyClass();
            var b = new MyClass();
            var list = new List<Extension.ITest> {a, b};
            
            Assert.Equal(3, list.ListLength());
        }
    }

    internal class MyClass : Extension.ITest
    {
        public void YTest()
        {
            throw new NotImplementedException();
        }
    }
}