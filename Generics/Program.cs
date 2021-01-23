using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T> // Genecic class //burdaki T hangi tipi verirsek ona dönüşüyor
    {
        T[] _array;
        T[] _tempArray;
        //MyList i new lediğim an bu çalışıyor.
        public MyList()
        {
            _array = new T[0]; //0 elemanlı bir array yapmış olduk
        }

        public void Add(T item)
        {
            _tempArray = _array;  //burda yaptığımız atama referans numarasıdır
            _array = new T[_array.Length + 1]; //eleman sayısını 1 arttırmış olduk
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            
            //son elemanı eklemiş olduğumuz kod
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
