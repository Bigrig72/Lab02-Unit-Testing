using System;
using Xunit;
using Lab02_Unit_Testing;

namespace ATM_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string balance = Program.AddToBalance(5000, 50).ToString();
            Assert.Equal(5050.ToString(), balance);
        }
    }
    public class UnitTest2
    {
        [Fact]
        public void Test2()
        {
            string balance = Program.AddToBalance(4000, 50).ToString();
            Assert.Equal(4050.ToString(), balance);
        }
    }

    public class UnitTest3
    {
        [Fact]
        public void Test3()
        {
            string balance = Program.SubtractFromBalance(4000, 100).ToString();
            Assert.Equal(3900.ToString(), balance);
        }
    }
    public class UnitTest4
    {
        [Fact]
        public void Test4()
        {
            string balance = Program.SubtractFromBalance(4000, 1000).ToString();
            Assert.Equal(3000.ToString(), balance);
        }
    }
}
