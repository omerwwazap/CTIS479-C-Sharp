using System.Collections;

namespace LeventDurdali_HomeWork1
{
    class BuyerCollection : IEnumerable
    {
        private ArrayList buyerFullName = new ArrayList();

        // indexer
        public Buyer this[int index]
        {
            get => (Buyer)buyerFullName[index];
            set => buyerFullName.Insert(index, value);
        }


        public Buyer GetPerson(int pos) => (Buyer)buyerFullName[pos];

        public void AddPerson(Buyer p) => buyerFullName.Add(p);


        public void ClearPeople() { buyerFullName.Clear(); }
        public int Count => buyerFullName.Count;

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => buyerFullName.GetEnumerator();
    }
}
