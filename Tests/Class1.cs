using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    [Category("Test")]
    public class Class1
    {
        int i = 10;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            i += 10;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(30, i + 10, "Zły wynik dodawania");
        }

        [Test]
        public void Test2()
        {
            Assert.GreaterOrEqual(30, i + 10, "Zły wynik dodawania");
        }

        [Test]
        public void Test3()
        {
            Assert.LessOrEqual(30, i + 10, "Zły wynik dodawania");
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(30 == i + 10, "Zły wynik dodawania");
        }

        [Test]
        public void Test5()
        {
            Assert.IsFalse(30 != i + 10, "Zły wynik dodawania");
        }

        [Test]
        public void Test6()
        {
            int k = i;
            k++;
            Assert.AreEqual(30, i + 10, "Zły wynik dodawania");
        }

        [Test]
        public void Test7()
        {
            Assert.Throws<DivideByZeroException>(() => { i /= 0; }, "Powinien być exception");
        }

        [Test]
        public void Test8()
        {
            Assert.DoesNotThrow(() => { int k = 0 / i; }, "Nie powinno być exceptiona");
        }

        [Test]
        public void Test9()
        {
            List<int> coll = new List<int>() { i, i+10 };
            Assert.Contains(i, coll, "Zła kolekcja");
        }

        [Test]
        public void Test10()
        {
            List<int> coll1 = new List<int>() { i, i + 10 };
            List<int> coll2 = new List<int>() { i + 10, i };
            Assert.That(coll1, Is.EquivalentTo(coll2), "Kolekcje powinny być równe");
        }

        [Test]
        public void Test11()
        {
            List<int> coll1 = new List<int>() { i, i + 10 };
            Assert.That(coll1, Has.No.Member(5), "Zła kolekcja");
        }

        [Test]
        public void Test12()
        {
            List<int> coll1 = null;
            Assert.IsNull(coll1, "Zła kolekcja");
        }

        [Test]
        public void Test13()
        {
            List<int> coll1 = new List<int>() { };
            Assert.IsEmpty(coll1, "Zła kolekcja");
        }

        [Test]
        public void Test14()
        {
            Assert.IsFalse(!true, "Lol");
        }

        [Test]
        public void Test15()
        {
            int[] iarray = new int[] { 1, 2, 3 };
            
            Assert.That(new List<int>() { 5 }, Is.Not.SubsetOf(iarray));
        }

        [Test]
        public void Test16()
        {
            int[] iarray = new int[] { 1, 2, 3 };

            Assert.That(iarray, Is.All.Not.Null);
        }

        [Test]
        public void Test17()
        {
            string[] sarray = new string[] { "a", "b", "c" };
            
            Assert.That(sarray, Is.All.InstanceOf(typeof(string)));
        }

        [Test]
        public void Test18()
        {
            string[] sarray = new string[] { "a", "b", "c" };
            
            Assert.That(sarray, Has.Member("b"));
        }

        [Test]
        public void Test19()
        {
            string[] sarray = new string[] { "a", "b", "c" };
            
            Assert.That(sarray, Contains.Item("c"));
        }

        [Test]
        public void Test20()
        {
            string[] sarray = new string[] { "a", "b", "c" };
            
            Assert.That(sarray, Has.No.Member("x"));
        }
    }
}
