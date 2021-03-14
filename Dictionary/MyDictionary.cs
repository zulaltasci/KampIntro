using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T>
    {
        T[,] items;
        T[,] tempArray;
        public MyDictionary()
        {
            items = new T[0, 0];
        }
        public void Add(T item)
        {
            items = tempArray;
            items = new T[items.Length + 1,items.Length+1];
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray.GetLength(1); j++)
                {
                   items[i, j]=tempArray[i,j] ;
                }
            }
            items[items.Length - 1,items.Length-1] = item;

        }
    }
}
