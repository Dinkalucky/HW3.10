using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public class MyList<T>
    {
        private List<T> myList = new List<T>();
        internal void AddElement(T v)
        {
            myList.Add(v);
        }

        public T this[int index]
        {
            get => myList[index];
        }

        public int NumberOfElements
        {
            get { return myList.Count; }
        }
    }
}
