using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generic
{
    internal class MyAnimalCollections<T>
        : System.Collections.IEnumerable
    {
        private System.Collections.ArrayList _animals;
        public MyAnimalCollections()
        {
            _animals = new System.Collections.ArrayList();
        }
        public T this[int indexPosition]
        {
            get
            {
                return (T)this._animals[indexPosition];            // unbox the item explicitly
            }
        }

        public void Add(T item)
        {
            _animals.Add(item);                                    // box the item implicitly
        }
        public IEnumerator GetEnumerator()
        {
            foreach (T animal in _animals)
            {
                yield return animal;
            }
        }
    }
}
