using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public static class ExtensionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] myList = new T[list.NumberOfElements];
            for (int i = 0; i < myList.Length; i++)
            {
                myList[i] = list[i];
            }

            return myList;
        }
    }
}
