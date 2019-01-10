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
}
