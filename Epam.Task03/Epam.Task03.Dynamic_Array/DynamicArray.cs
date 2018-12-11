using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03.Dynamic_Array
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private const int Cap = 8;
        private int count = 0;

        public DynamicArray() : this(Cap)
        {
        }

        public DynamicArray(int n)
        {
            this.Arr = new T[n];
            this.count = 0;
        }

        public DynamicArray(IEnumerable<T> coll)
        {
            this.Arr = new T[coll.Count()];

            for (int i = 0; i < coll.Count(); i++)
            {
                this.Add(coll.ElementAt<T>(i));
                this.count++;
            }
        }

        public T[] Arr { get; set; }

        public int Capacity
        {
            get
            {
                return this.Arr.Length;
            }
        }

        public int MyLength
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (this.count == 0)
                {
                    throw new Exception("Dynamic array is not initialized");
                }
                else
                {
                    if (index < 0)
                    {
                        throw new Exception("index can not be negative");
                    }
                    else
                    {
                        if (index > this.MyLength - 1)
                        {
                            throw new Exception("ArgumentOutOfRangeException");
                        }
                        else
                        {
                            return this.Arr[index];
                        }
                    }
                }
            }

            set
            {
                if (this.count == 0)
                {
                    throw new Exception("Dynamic array is not initialized");
                }
                else
                {
                    if (index < 0)
                    {
                        throw new Exception("index can not be negative");
                    }
                    else
                    {
                        if (index > this.MyLength - 1)
                        {
                            throw new Exception("ArgumentOutOfRangeException");
                        }
                        else
                        {
                            this.Arr[index] = value;
                        }
                    }
                }
            }
        }

        public void Add(T elem)
        {
            if (this.Capacity == this.MyLength)
            {
                this.count = this.Capacity;
                T[] temp = new T[2 * this.MyLength];
                Array.Copy(this.Arr, temp, this.MyLength);
                this.Arr = temp;
                this.Arr[this.count] = elem;
                this.count++;
            }
            else
            {
                this.Arr[this.count] = elem;
                this.count++;
            }
        }

        public void AddRange(IEnumerable<T> coll)
        {
            if (coll.Count() > 0)
            {
                if (coll.Count() > this.MyLength - this.count)
                {
                    T[] temp = new T[this.MyLength + coll.Count()];
                    Array.Copy(this.Arr, temp, this.MyLength);
                    this.Arr = temp;
                }

                for (int i = 0; i < coll.Count(); i++)
                {
                    this.Arr[this.count + i] = coll.ElementAt<T>(i);
                }
            }
        }

        public bool Insert(int index, T item)
        {
            if ((index >= 0) && (index < this.MyLength - 1))
            {
                {
                    if (this.MyLength == this.Capacity)
                    {
                        this.count = this.Capacity;
                        T[] temp = new T[2 * this.MyLength];
                        Array.Copy(this.Arr, temp, this.MyLength);
                        this.Arr = temp;
                    }

                    for (int i = this.MyLength - 1; i >= index; i--)
                    {
                        this.Arr[i + 1] = this.Arr[i];
                    }

                    this.Arr[index] = item;
                    this.count++;
                    return true;
                }
            }
            else
            {
                if (index == this.MyLength - 1)
                {
                    this.Add(item);
                    return true;
                }
                else
                {
                    if ((index >= this.MyLength) && (index < this.Capacity - 1))
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception("ArgumentOutOfRangeException");
                    }
                }
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.Arr[i].Equals(item))
                {
                    for (int j = i; j < this.count - 1; j++)
                    {
                        this.Arr[j] = this.Arr[j + 1];
                    }

                    this.Arr[this.count - 1] = default(T);
                    this.count--;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if ((index >= 0) && (index < this.count - 1))
            {
                for (int i = index; i < this.count - 1; i++)
                {
                    this.Arr[i] = this.Arr[i + 1];
                }

                this.Arr[this.count - 1] = default(T);
                this.count--;
                return true;
            }

            if (index == this.count - 1)
            {
                this.Arr[this.count - 1] = default(T);
                this.count--;
                return true;
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.MyLength; i++)
            {
                yield return this.Arr[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)this.Arr).GetEnumerator();
        }
    }
}
