using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RGR10;
namespace RGRTest10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Vector1AddTest()
        {
            Vector1D expected = new Vector1D(1);
            Vector1D a = new Vector1D(0.5);
            Vector1D b = new Vector1D(0.5);
            Assert.AreEqual(expected.x, (a + b).x);
        }

        [TestMethod]
        public void Vector1SubTest()
        {
            Vector1D expected = new Vector1D(0);
            Vector1D a = new Vector1D(0.5);
            Vector1D b = new Vector1D(0.5);
            Assert.AreEqual(expected.x, (a - b).x);
        }

        [TestMethod]
        public void Vector1MulTest()
        {
            Vector1D a = new Vector1D(0.5);
            Vector1D b = new Vector1D(0.5);
            Assert.AreEqual(0.25, a * b);
        }

        [TestMethod]
        public void Vector1Length()
        {
            Vector1D a = new Vector1D(-1);
            Assert.AreEqual(1, a.Length());
        }

        [TestMethod]
        public void Vector2AddTest()
        {
            Vector2D expected = new Vector2D(1,-1);
            Vector2D a = new Vector2D(0.5,-1);
            Vector2D b = new Vector2D(0.5,0);
            Assert.AreEqual(expected.x, (a + b).x);
            Assert.AreEqual(expected.y, (a + b).y);
        }

        [TestMethod]
        public void Vector2SubTest()
        {
            Vector2D expected = new Vector2D(0, -1);
            Vector2D a = new Vector2D(0.5, -1);
            Vector2D b = new Vector2D(0.5, 0);
            Assert.AreEqual(expected.x, (a - b).x);
            Assert.AreEqual(expected.y, (a - b).y);
        }

        [TestMethod]
        public void Vector2MulTest()
        {
            Vector2D a = new Vector2D(0.5, -1);
            Vector2D b = new Vector2D(0.5, 0);
            Assert.AreEqual(0.25, a * b);
        }

        [TestMethod]
        public void Vector2Length()
        {
            Vector2D a = new Vector2D(-1,1);
            Assert.AreEqual(Math.Sqrt(2),a.Length());
        }

        [TestMethod]
        public void Vector2Angle()
        {
            Vector2D a = new Vector2D(1, 0);
            Vector2D b = new Vector2D(0, 1);
            Assert.AreEqual(0, a.AngleBetween(b));
        }

        [TestMethod]
        public void Vector3AddTest()
        {
            Vector3D expected = new Vector3D(1, -1, 10);
            Vector3D a = new Vector3D(0.5, -1, -2);
            Vector3D b = new Vector3D(0.5, 0, 12);
            Assert.AreEqual(expected.x, (a + b).x);
            Assert.AreEqual(expected.y, (a + b).y);
            Assert.AreEqual(expected.z, (a + b).z);
        }

        [TestMethod]
        public void Vector3SubTest()
        {
            Vector3D expected = new Vector3D(0, -1, -10);
            Vector3D a = new Vector3D(0.5, -1, 2);
            Vector3D b = new Vector3D(0.5, 0, 12);
            Assert.AreEqual(expected.x, (a - b).x);
            Assert.AreEqual(expected.y, (a - b).y);
            Assert.AreEqual(expected.z, (a - b).z);
        }

        [TestMethod]
        public void Vector3MulTest()
        {
            Vector3D a = new Vector3D(0.5, -1, 2);
            Vector3D b = new Vector3D(0.5, 0, 2);
            Assert.AreEqual(4.25, a * b);
        }

        [TestMethod]
        public void Vector3Length()
        {
            Vector3D a = new Vector3D(2, 2, 1);
            Assert.AreEqual(3, a.Length());
        }

        [TestMethod]
        public void Vector3Angle()
        {
            Vector3D a = new Vector3D(1, -1, -1);
            Vector3D b = new Vector3D(1, -1, 2);
            Assert.AreEqual(0, a.AngleBetween(b));
        }

        [TestMethod]
        public void Vector3Vec()
        {
            Vector3D expected = new Vector3D(1, -1, 0);
            Vector3D a = new Vector3D(1, 1, 0);
            Vector3D b = new Vector3D(0, 0, 1);
            Assert.AreEqual(expected.x, (a ^ b).x);
            Assert.AreEqual(expected.y, (a ^ b).y);
            Assert.AreEqual(expected.z, (a ^ b).z);
        }
    }
}
