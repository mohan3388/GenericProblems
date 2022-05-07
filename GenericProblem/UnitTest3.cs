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
            string val = number.FindMax("Peach", "Apple", "Banana");
            Assert.AreEqual(val,"Banana");
        }
    }
}