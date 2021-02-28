using System;
using System.Collections.Generic;
using System.Text;

//21.Create a generic class
namespace CTIS479_Homework_1
{
    class DataStore<T>
    {
        private T[] store;
        public DataStore()
        {
            store = new T[10];
        }

        public DataStore(int length)
        {
            store = new T[length];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= store.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                return store[index];
            }

            set
            {
                if (index < 0 || index >= store.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                store[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return store.Length;
            }
        }
    }
}
