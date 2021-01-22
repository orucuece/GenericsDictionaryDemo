using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;

        //ctor: 
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {

            K[] tempKeyArray = keys;
            V[] tempValArray = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


            foreach (var keyItem in keys)
            {
                Console.WriteLine("Key: " + keyItem);
            }

            foreach (var valItem in values)
            {
                Console.WriteLine("Value: " + valItem);
            }

        }
    }
}
