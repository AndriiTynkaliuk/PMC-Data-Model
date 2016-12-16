using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Creates enumerator for Containers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ContainersEnumerator<T> : Enumerator<Container<T>> where T : struct
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContainersEnumerator() { }

        /// <summary>
        /// Constructor which takes collection as a parameter
        /// </summary>
        /// <param name="coll"></param>
        public ContainersEnumerator(Containers<T> coll)
        {
            this.coll = coll;
            position = -1;
            current = default(Container<T>);
        }
    }
}
