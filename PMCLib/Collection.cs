using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCLib
{
    /// <summary>
    /// Base class for collections
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Collection<T> : ICollection<T>
    {
        protected ArrayList arrayList;
        protected bool isReadOnly = false;

        /// <summary>
        /// Default constructor
        /// Initializes new collection
        /// </summary>
        public Collection()
        {
            arrayList = new ArrayList();
        }

        /// <summary>
        /// Returns number of elements in the collection
        /// </summary>
        public int Count
        {
            get
            {
                return arrayList.Count;
            }
        }

        /// <summary>
        /// Returns True if the collection is only for read.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
            set
            {
                isReadOnly = value;
            }
        }

        /// <summary>
        /// Adds new item to the collection
        /// </summary>
        /// <param name="item"></param>
        public abstract void Add(T item);

        /// <summary>
        /// Removes all elements in the colletion
        /// </summary>
        public void Clear()
        {
            if (isReadOnly == false)
                arrayList.Clear();
            else
                throw new NotSupportedException("The collection is read-only");
        }

        /// <summary>
        /// Returns True if the collection contains needed element
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            foreach (var element in arrayList)
            {
                if (element.Equals(item))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Get or Set collection index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return (T)arrayList[index];
            }
            set
            {
                arrayList[index] = value;
            }
        }

        /// <summary>
        /// Copies the elements from the Collection to destination Array.
        /// Starting at a current index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("Array");
            else if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException();
            else if (array.Length - arrayIndex < Count)
                throw new ArgumentException("Not enough elements in the destination Array");
            else
            {
                for (int i = 0; i < Count; i++)
                    array.SetValue(this[i], arrayIndex);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            yield return (T)arrayList.GetEnumerator();
        }

        /// <summary>
        /// Removes specific item from the collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            if (!isReadOnly)
            {
                if (arrayList.Contains(item))
                {
                    arrayList.Remove(item);
                    return true;
                }
                else
                    return false;
            }
            else
                throw new NotSupportedException("The collection is read-only");
        }

        /// <summary>
        /// Removes the element at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            arrayList.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Returns an Enumarator object
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
