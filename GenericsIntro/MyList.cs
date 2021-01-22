using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //geçici liste
            T[] tempArray = items;
            //listemize eleman ekliyoruz bir arttırarak
            items = new T[items.Length+1];
            //geçici listeden elemanlarımızı items listemize geri çağırıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[0] = tempArray[i];
            }

            //items'ın son elmanı ekleme -1 dememizin nedeni indeksler 0 dan başlar mesala 6.eleman için 5.indeks çağırılır.
            items[items.Length - 1] = item;
        }
    }
}
