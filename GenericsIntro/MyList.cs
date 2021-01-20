using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor-->
        public MyList()///Constructor fonk sayesinde bizim classımız çalışır çalışmaz bu kısım da çalışacak
        {
            items = new T[0];//Her newlemede array sayısını yeniden almak için konumu değiştiriyıruz.
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//temparrayda tuttuğum verileri tekrardan ana itemsa atadık
            }
            items[items.Length - 1] = item;
        }  

    }
}
