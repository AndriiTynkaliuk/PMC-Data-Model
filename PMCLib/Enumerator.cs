using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMCLib
{
    /// <summary>
    /// Base class for enumerator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Enumerator<T> : IEnumerator<T>
    {
        protected Collection<T> coll;
        protected int position;
        protected T current;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Enumerator() { }

        /// <summary>
        /// Constructor with parameter
        /// Initializes collection and position
        /// </summary>
        /// <param name="coll"></param>
        public Enumerator(Collection<T> coll)
        {
            this.coll = coll;
            position = -1;
            current = default(T);
        }

        /// <summary>
        /// Returns current element in enum
        /// </summary>
        public T Current
        {
            get
            {
                return current;
            }
        }

        /// <summary>
        /// Returns current element in enum
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return current;
            }
        }

        /// <summary>
        /// Sets to default
        /// </summary>
        public virtual void Dispose()
        {
            coll = null;
            position = -1;
            current = default(T);
        }

        /// <summary>
        /// Moves the enumerator to the next element
        /// </summary>
        /// <returns></returns>
        public virtual bool MoveNext()
        {
            if (position < coll.Count)
            {
                position++;
                current = (T)coll[position];
                return (position < coll.Count);
            }
            else
                return false;               
        }

        /// <summary>
        /// Sets the enumerator in before the first element in the collection
        /// </summary>
        public virtual void Reset()
        {
            position = -1;
            current = default(T);
        }
    }
}
