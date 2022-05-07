using FindMaxNumber;
using NUnit.Framework;

namespace TestProgram
{
    public class Tests
    {
        [Test]
        public void Testr()
        {
            Generics number = new Generics();
            float num= number.FindMax(30.4f, 19.02f, 22.54f);
            Assert.AreEqual(num, 30.4f);
        }
    }
}