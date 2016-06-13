using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11.GenericListAndOperations
{
    class GenericClass<T>
    {

        private T[] elements;
        private int counter;

        public GenericClass(int size)
        {
            elements = new T[size];
        }

        public void Add(T element)
        {
            if (counter >= this.elements.Length)
            {
                Array.Resize(ref this.elements, this.elements.Length*2);
            }
            this.elements[counter] = element;
            counter++;
        }

        public T this[int index]
        {
            get
            {
                IndexValidation(index);
                return this.elements[index];
            }
        }

        public void Remove(int index)
        {
            IndexValidation(index);
            this.elements[index] = default(T);
        }

        public void Insert(int index, T item)
        {
            IndexValidation(index);
            var buffer = new List<T>(this.elements);
            buffer.Insert(index, item);
            this.elements = new T[buffer.Count * 2];
            this.elements = buffer.ToArray();
            counter++;
        }

        public void ClearArr()
        {
            this.elements = new T[this.elements.Length];
            counter = 0;
        }

        public int FindIndexOfElement(T item)
        {
            int indexOfItem = Array.IndexOf(this.elements, item);
            return indexOfItem;
        }

        public void IndexValidation(int index)
        {
            if (index > counter || index < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("oops, out of range. max index is {0}. Min index is 0", this.elements.Length));
            }
        }

        public void Min<T>() where T :IComparable
        {
            Array.Sort(this.elements);

            Console.WriteLine(this.elements[0]);
        }

        public void Max<T>() where T : IComparable
        {
            Array.Sort(this.elements);
            Array.Reverse(this.elements);
            Console.WriteLine(this.elements[0]);
            //ToDo take care of the case whn arr just doubled its size.
        }

        public override string ToString()
        {
            string message = "This is an array of {0} elements.";
            return string.Format(message, this.elements.Length);
        }



       
    }
}
