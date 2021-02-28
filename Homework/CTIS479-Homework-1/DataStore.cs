using System;

//21.Create a generic class
//16.Implement at least one indexer
namespace LeventDurdali_HomeWork1
{
    class DataStore<T>
    {
        private T[] store;
        public DataStore()
        {
            store = new T[5];
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
