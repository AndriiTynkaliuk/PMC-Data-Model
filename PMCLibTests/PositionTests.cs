using PMCLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib.Tests
{
    /// <summary>
    /// Class for testing Position class methods
    /// </summary>
    [TestFixture]
    public class PositionTest
    {
        static Position<int> position;
        Point<int> point = new Point<int>(0, 0);

        [Test]
        public void Initialization()
        {
            position = new Position<int>();

            var random = new Random();

            for (int i = 0; i < 500; i++)
                position.Add(new Point<int>(random.Next(1, 99), random.Next(1, 99)));
            Assert.AreEqual(500, position.Count);
        }

        [Test]
        public void PointTest()
        {
            Assert.IsNotNull(point);
        }

        [Test]
        public void TestAddToPosition()
        {
            position.Add(point);
            Assert.IsTrue(position.Contains(point));
        }

        [Test]
        public void TestRemovePoint()
        {
            position.Remove(point);
            Assert.IsFalse(position.Contains(point));
        }

        [Test]
        public void TestClearPosition()
        {
            position.Clear();
            Assert.AreEqual(0, position.Count);
        }

        [Test]
        public void CopyToTest()
        {
            Point<int> p = new Point<int>(0, 0);
            Position<int> pos = new Position<int>();
            pos.Add(p);
            Point<int>[] pArr = new Point<int>[] { new Point<int>(1, 1), new Point<int>(2, 2) }; 
            pos.CopyTo(pArr, 1);

            Assert.AreEqual(2, pArr.Length);
        }

        [Test]
        public void EnumeratorTest()
        {
            Position<int> pos = new Position<int>();
            pos.Add(new Point<int>(0, 0));
            pos.Add(new Point<int>(1, 1));
            PositionEnumerator<int> en = new PositionEnumerator<int>(pos);
            en.MoveNext();

            Assert.AreEqual(en.Current, pos[0]);

            en.Reset();
            Assert.IsNull(en.Current);
        }
    }
}