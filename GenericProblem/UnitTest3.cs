using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test3
    {
        [Test]
        public void Test1()
        {
            Generics number = new Generics();
            int num = number.FindMax(20, 28, 49);
            Assert.AreEqual(num, 49);
        }
    }
}