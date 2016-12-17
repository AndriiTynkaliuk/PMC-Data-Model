using System;
using NUnit.Framework;
using PMCLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLibTests
{
    [TestFixture]
    public class ContainerTest
    {
        static Position<int> position;
        static Matrix<int> Matrix;
        static Point<int> Point;
        static Container<int> Contatiner;

        [Test]
        public void TestAddToContainer()
        {
            position = new Position<int>();
            Matrix = new Matrix<int>();
            Contatiner = new Container<int>();

            var random = new Random();
            for (int k = 0; k < 50; k++)
            {
                for (int i = 0; i < 100; i++)
                {
                    position.Clear();
                    for (int j = 0; j < 400; j++)
                    {
                        position.Add(new Point<int>(random.Next(1, 99), random.Next(1, 99)));
                    }
                    Matrix.Add(position);
                }
                Contatiner.Add(Matrix);
            }
            Assert.AreEqual(50, Contatiner.Count);
            Assert.IsTrue(Contatiner.Remove(0));
        }

        [Test]
        public void TestClearContainer()
        {
            Contatiner.Clear();
            Assert.AreEqual(0, Contatiner.Count);
        }
    }
}
