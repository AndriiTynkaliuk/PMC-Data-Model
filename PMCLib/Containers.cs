using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Creates new collection for Container
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Containers<T> : Collection<Container<T>> where T : struct
    {
        /// <summary>
        /// Adds new element to the Containers
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Container<T> item)
        {
            arrayList.Add(item);
        }
    }
}
