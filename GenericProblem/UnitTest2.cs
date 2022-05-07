using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Test1()
        {
            Generics number = new Generics();
            int num = number.FindMax(14, 45, 7);
            Assert.AreEqual(num, 45);
        }
    }
}