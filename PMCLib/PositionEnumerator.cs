using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Class for creating enumerator for Position collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PositionEnumerator<T> : Enumerator<Point<T>> where T : struct
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public PositionEnumerator() { }

        /// <summary>
        /// Constructor which takes collection as a parameter
        /// </summary>
        /// <param name="coll"></param>
        public PositionEnumerator(Position<T> coll)
        {
            this.coll = coll;
            position = -1;
            current = default(Point<T>);
        }
    }
}
