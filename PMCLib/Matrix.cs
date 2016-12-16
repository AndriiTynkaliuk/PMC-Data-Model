using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Class for creating Matrix collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T> : Collection<Position<T>> where T : struct
    {
        /// <summary>
        /// Adds new element to Matrix
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Position<T> item)
        {
            arrayList.Add(item);
        }
    }
}
