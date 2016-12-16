using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCLib
{
    /// <summary>
    /// Point class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point<T> where T : struct
    {
        // Static fileds x,y,z
        private T x;
        private T y;
        private T z;

        /// <summary>
        /// Gets or Sets X value.
        /// </summary>
        public T X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        /// <summary>
        /// Gets or Sets Y value
        /// </summary>
        public T Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        /// <summary>
        /// Gets or Sets z value
        /// </summary>
        public T Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        /// <summary>
        /// 2D constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point (T x, T y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// 3D constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point (T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Displays (X,Y,Z) values.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "X = " + X.ToString() + "; Y = " + Y.ToString() + "; Z = " + Z.ToString();
        }
    }
}
