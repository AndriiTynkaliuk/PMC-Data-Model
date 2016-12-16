using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Class for creating position collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Position<T> : Collection<Point<T>> where T : struct
    {
        /// <summary>
        /// Adds new element to the Position
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Point<T> item)
        {
            arrayList.Add(item);
        }
    }
}
