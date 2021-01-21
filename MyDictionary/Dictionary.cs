using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<T, Tvalue>
    {
        T[] akey;
        Tvalue[] avalue;
        
        public Dictionary()
        {
            akey = new T[0];
            avalue = new Tvalue[0];
            
        }

        public void Add(T key, Tvalue value)
        {
            T[] tempKey = akey;
            Tvalue[] tempValue = avalue;
           

            akey = new T[akey.Length + 1];
            avalue = new Tvalue[avalue.Length + 1];
            


            for (int i = 0; i < tempKey.Length; i++)
            {
                akey[i] = tempKey[i];
                avalue[i] = tempValue[i];
               

            }

            akey[akey.Length - 1] = key;
            avalue[avalue.Length - 1] = value;
            

        }

        public T[] Key
        {
            get { return akey; }
        }

        public Tvalue[] Value
        {
            get { return avalue; }
        }

        

    }
}
