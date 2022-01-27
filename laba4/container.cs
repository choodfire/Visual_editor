using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Container<Base>        //хранилище
    {
        private int size;
        private Base[] arr;
        public Container()
        {
            arr = null;
        }
        public Container(int size)
        {
            this.size = size;
            arr = new Base[size];

        }

        public Base this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }
        public void addObject(Base obj)
        {
            if (size == 0)
            {
                arr = new Base[1];
                arr[0] = obj;
                size = 1;
            }
            else
            {
                Base[] new_arr = new Base[size + 1];
                for (int i = 0; i < size; i++)
                {
                    new_arr[i] = arr[i];
                }
                new_arr[size] = obj;
                arr = new_arr;
                size += 1;
            }
        }
        public void deleteObject(int index)
        {
            Base[] new_arr = new Base[size - 1];
            for (int i = 0; i < index; i++)
                new_arr[i] = arr[i];
            for (int i = index + 1; i < size; i++)
                new_arr[i - 1] = arr[i];
            arr = new_arr;
            size -= 1;
        }

        public int getSize() //вернуть размер
        {
            return size;
        }
    }

}