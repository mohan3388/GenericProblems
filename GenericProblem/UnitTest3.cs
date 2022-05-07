using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test3
    {
        [Test]
        public void Test()
        {
            Generics number = new Generics();
            float num = number.FindMax(30.4f, 41.02f, 45.54f);
            Assert.AreEqual(num, 45.54f);
        }
    }
}