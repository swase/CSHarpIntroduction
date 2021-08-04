using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OOP_PracticeApp;

namespace TestClass
{
    class StructPointTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, 0)]
        [TestCase(1, 2, 3)]
        [TestCase(10, 20, 300)]
        public void InsatntiatingAClass_Customer_GivesExpectedValue(int x, int y, int z)
        {
            Program.Point3D point = new Program.Point3D(x, y, z);
            Assert.AreEqual(x, point.x);
            Assert.AreEqual(y, point.y);
            Assert.AreEqual(z, point.z);
        }

        [TestCase(0, 0)]
        [TestCase(1, 2)]
        [TestCase(10, 20)]
        public void InsatntiatingAClass_Customer_GivesExpectedValue(int x, int y)
        {
            Program.Point3D point = new Program.Point3D(x, y);
            Assert.AreEqual(x, point.x);
            Assert.AreEqual(y, point.y);
            Assert.AreEqual(5, point.z);
        }
    }
}
