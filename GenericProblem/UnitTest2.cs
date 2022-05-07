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
            string val = number.FindMax("Apple", "Banana", "Peach");
            Assert.AreEqual(val,"Banana");
        }
    }
}