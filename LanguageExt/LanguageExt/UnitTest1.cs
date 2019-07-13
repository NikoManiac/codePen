using System;
using Xunit;
using LanguageExt;
using static LanguageExt.Prelude;

namespace LanguageExt
{
    public class UnitTest1
    {
        [Fact]
        public void TestTuple()
        {
            var name = Tuple("Paul","Louth");
            var res = name.Map( (first, last) => $"{first} {last}");
            
            Assert.Equal("Paul Louth", res);
        }

        [Fact]
        public void TestOptional()
        {
            var optional = Some(123);
            var x = optional.Match(
                Some: sx => sx  * 2,
                None: () => 0
            );
            
            Assert.Equal(246, x);
        }

        [Fact]
        public void TestNullable()
        {
            var x  = GetValue()
            
            Assert.Equal(0, x);
        }
    }
}