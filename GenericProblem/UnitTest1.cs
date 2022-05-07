using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Generics number = new Generics();
            int num= number.FindMax(30, 14, 7);
            Assert.AreEqual(num, 30);
        }
    }
}