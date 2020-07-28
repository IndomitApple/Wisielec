using NUnit.Framework;
using Wisielec;

namespace NUnitTestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test_losowania_slowa()
        {
            string test_slowo = new Form1().losuj_slowo();
            Assert.IsNotNull(test_slowo);
        }
        [Test]
        public void test_ilosci_bledow()
        {
            int test_liczba_bledow = new Form1().ile_pudel;
            Assert.AreEqual(0, test_liczba_bledow);
        }
    }
}