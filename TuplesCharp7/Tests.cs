using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuplesCharp7;

namespace Tests
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void TupleExample1_Test()
        {
            var personExample1 = TupleExample1.GetNameBlogAndAge();
            Assert.AreEqual("Nikola Zivkovic", personExample1.Item1);
            Assert.AreEqual("www.rubikscode.net", personExample1.Item2);
            Assert.AreEqual(30, personExample1.Item3);
        }

        [TestMethod]
        public void TupleExample2_Test()
        {
            var (name, blog, age) = TupleExample2.GetNameBlogAndAge();
            Assert.AreEqual("Nikola Zivkovic", name);
            Assert.AreEqual("www.rubikscode.net", blog);
            Assert.AreEqual(30, age);
        }

        [TestMethod]
        public void TupleExample3_Test()
        {
            var personExample3 = TupleExample3.GetNameBlogAndAge();
            Assert.AreEqual("Nikola Zivkovic", personExample3.name);
            Assert.AreEqual("www.rubikscode.net", personExample3.blog);
            Assert.AreEqual(30, personExample3.age);
        }

        [TestMethod]
        public void TupleExample4_Test()
        {
            var personExample4 = TupleExample4.GetNameBlogAndAge();
            Assert.AreEqual("Nikola Zivkovic", personExample4.name);
            Assert.AreEqual("www.rubikscode.net", personExample4.blog);
            Assert.AreEqual(30, personExample4.age);
        }
    }
}
