using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Class for creating enumerator for Matrix collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MatrixEnumerator<T> : Enumerator<Position<T>> where T : struct
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public MatrixEnumerator() { }

        /// <summary>
        /// Constructor which takes collection as a parameter
        /// </summary>
        /// <param name="coll"></param>
        public MatrixEnumerator(Matrix<T> coll)
        {
            this.coll = coll;
            position = -1;
            current = default(Position<T>);
        }
    }
}
