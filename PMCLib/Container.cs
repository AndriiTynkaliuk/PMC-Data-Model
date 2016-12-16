using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Creates new Container for Matrix
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Container<T> : Collection<Matrix<T>> where T : struct
    {
        /// <summary>
        /// Adds new element to the Container
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Matrix<T> item)
        {
            arrayList.Add(item);
        }
    }
}
