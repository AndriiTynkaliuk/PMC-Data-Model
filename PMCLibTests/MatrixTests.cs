using System;
using PMCLib;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLibTests
{
    [TestFixture]
    public class MatrixTests
    {
        static Position<int> position;
        static Matrix<int> Matrix;

        [Test]
        public void TestAddToMatrix()
        {
            position = new Position<int>();
            Matrix = new Matrix<int>();

            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                position.Clear();
                for(int j = 0; j < 400; j++)
                {
                    position.Add(new Point<int>(random.Next(1, 99), random.Next(1, 99)));
                }
                Matrix.Add(position);
            }

            Assert.AreEqual(100, Matrix.Count);
            Assert.IsTrue(Matrix.Remove(0));
        }

        [Test]
        public void TestRemoveMatrix()
        {
            Assert.IsTrue(position.Remove(0));            
        }

        [Test]
        public void TestClearMatrix()
        {
            Matrix.Clear();
            Assert.AreEqual(0, Matrix.Count);
        }

    }
}
