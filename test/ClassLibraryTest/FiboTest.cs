using System;
using Xunit;
using ClassLibrary;

namespace ClassLibraryTest
{

    public class FiboTest
    {
        private readonly Fibo fibo;
        
        public FiboTest()
        {
            fibo = new Fibo();
        }

        [Fact]
        public void TestCompute()
        {
            Assert.Equal(55, fibo.Compute(10));
            Assert.Equal(6765, fibo.Compute(20));
        }
    }
}
