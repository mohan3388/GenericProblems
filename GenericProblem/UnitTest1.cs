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
            string val= number.FindMax("Banana", "Peach", "Apple");
            Assert.AreEqual(val, "Banana");
        }
    }
}