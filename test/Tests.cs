using System;
using Xunit;
using ClassLibrary;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test2() {
            var c = new Class1();
            var i = c.Method1();
            Assert.True(i == 4);

        }
    }
}
