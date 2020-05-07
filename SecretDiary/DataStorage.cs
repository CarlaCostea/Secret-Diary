using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SecretDiary
{
    public class DataStorage<T> : IList<T>
    {
        private List<RegisterEvent> events;
        T = RegisterEvent;

        public DataStorage()
        {
            events = new List<RegisterEvent>();
        }

        public int Count { get; }

        public bool IsReadOnly { get; }

        public T this[int index]
        {
            get => events[index];
            set
            {
                if (index < 0 && index > Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index should be inside the array boundaries");
                }

                elements[index] = value;
            }
        }

        public void Add(T item)
        {
            events.Add(new RegisterEvent(item));
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
