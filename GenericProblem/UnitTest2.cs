using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Test2
    {
        [Test]
        public void Tests()
        {
            Generics number = new Generics();
            float num = number.FindMax(30.4f, 41.02f, 35.54f);
            Assert.AreEqual(num, 41.02f);
        }
    }
}