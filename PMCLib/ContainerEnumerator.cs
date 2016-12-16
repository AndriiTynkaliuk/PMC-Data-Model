using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Creates enumerator for Container
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ContainerEnumerator<T> : Enumerator<Matrix<T>> where T : struct
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContainerEnumerator() { }

        /// <summary>
        /// Constructor which takes collection as a parameter
        /// </summary>
        /// <param name="coll"></param>
        public ContainerEnumerator(Container<T> coll)
        {
            this.coll = coll;
            position = -1;
            current = default(Matrix<T>);
        }
    }
}
