using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Container<T>        //хранилище
    {
        private int size;
        private int capacity;
        private const int dop = 10;
        private T[] arr;
        public Container()
        {
            arr = null;
        }
        public Container(int size)
        {
            this.size = size;
            capacity = size + dop;
            arr = new T[size + dop];

        }

        

        public T this[int index]
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
        public void resizeStorage(int new_size)                //задать размер
        {
            if (new_size < this.size)
            {
                Console.WriteLine("New size must be larger than previous");

            }
            else
            {
                T[] arr = new T[new_size];
                size = 0;
                capacity = new_size + dop;

            }


        }
        public void addToEnd(ref T elem)
        {
            if (arr == null)
            {
                arr = new T[5];
                arr[0] = elem;
                size = 1;
                capacity = 5;
            }
            else if (arr != null)
            {
                if (size == capacity)
                {
                    size++;
                    T[] new_arr = new T[size + dop];
                    for (int i = 0; i < size - 1; i++)
                        new_arr[i] = arr[i];
                    new_arr[size - 1] = elem;

                    arr = new_arr;
                    capacity = size + dop;
                }
                else
                {
                    arr[size] = elem;
                    size++;
                }
            }


        }
        public void removeObject()
        {
            if (arr != null && size > 0)
            {
                if (size < capacity / 4 && size > 50)
                {
                    size--;
                    T[] newarr = new T[size + dop];
                    for (int i = 0; i < size; i++)
                        newarr[i] = arr[i];
                    //
                    arr = newarr;
                    capacity = size + dop;
                }
                else size--;
            }

        }

        public void addBegin(T elem)
        {
            if (arr == null)
            {
                arr = new T[5];
                arr[0] = elem;
                size = 1;
                capacity = 5;
            }
            else
            {
                if (size == capacity)
                {
                    size++;
                    T[] newarr = new T[size + dop];
                    newarr[0] = elem;
                    for (int i = 0; i < size - 1; i++)
                        newarr[i + 1] = arr[i];

                    arr = newarr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = size - 1; i >= 0; i--)
                        arr[i + 1] = arr[i];
                    size++;
                    arr[0] = elem;
                }
            }


        }
        public void deleteObject(int index)
        {
            if (arr != null && size > 0)
            {
                if (size < capacity / 4 && size > 50)
                {
                    size--;

                    T[] _arr = new T[size + dop];
                    for (int i = 0, k = 0; i < size + 1; i++)
                        if (i != index)
                        {
                            _arr[k] = arr[i];
                            k++;
                        }
                    arr = _arr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = index + 1; i < size; i++)
                        arr[i - 1] = arr[i];
                    size--;
                }
            }
        }


        public void deleteTheFirst()
        {
            if (arr != null && size > 0)
            {
                if (size < capacity / 4 && size > 50)
                {
                    size--;
                    T[] newarr = new T[size + dop];
                    for (int i = 1; i < size + 1; i++)
                        newarr[i - 1] = arr[i];

                    arr = newarr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = 1; i < size; i++)
                        arr[i - 1] = arr[i];
                    size--;
                }
            }

        }

        public int getSize()                           //вернуть размер
        {
            return size;
        }
        public int getCapacity()                         //вернуть размер расширенного массива
        {
            return capacity;
        }

    }

}
