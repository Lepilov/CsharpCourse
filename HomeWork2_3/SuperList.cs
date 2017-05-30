using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class SuperList<T> : ICollection<T>
    {
        private List<T> ListCollection;

        public event EventHandler<ItemAddedEventArgs<T>> ItemAdded;

        public event EventHandler<ItemAddingEventArgs<T>> ItemAdding;

        public event EventHandler<ItemRemovedEventArgs<T>> ItemRemoved;

        public event EventHandler<ItemRemovingEventArgs<T>> ItemRemoving;

        public event EventHandler<ListClearedEventArgs<T>> ListCleared;

        public event EventHandler<ListClearingEventArgs<T>> ListClearing;

        public int Count => ListCollection.Count;

        public bool IsReadOnly => (ListCollection as ICollection<T>).IsReadOnly;

        public SuperList()
        {
            ListCollection = new List<T>();
        }

        public void Add(T item)
        {
            var arg = new ItemAddingEventArgs<T>();
            arg.Item = item;
            if (this.ItemAdding != null)
            {
                this.ItemAdding(this, arg);
            }

            if (arg.Cancel)
            {
                Console.WriteLine("Добавление элемента отменено");
                return;
            }

            ListCollection.Add(item);

            if (this.ItemAdded != null)
            {
                this.ItemAdded(this, new ItemAddedEventArgs<T> { Item = item });
            }
        }

        public void Clear()
        {
            var arg = new ListClearingEventArgs<T>();

            if (this.ListClearing != null)
            {
                this.ListClearing(this, arg);
            }

            if (arg.Cancel)
            {
                Console.WriteLine("Очистка листа отменена");
                return;
            }

            ListCollection.Clear();

            if (this.ListCleared != null)
            {
                this.ListCleared(this, new ListClearedEventArgs<T>());
            }
        }

        public bool Remove(T item)
        {
            var arg = new ItemRemovingEventArgs<T>();
            arg.Item = item;
            if (this.ItemRemoving != null)
            {
                this.ItemRemoving(this, arg);
            }

            if (arg.Cancel)
            {
                Console.WriteLine("Удаление элемента отменено");
                return false;
            }

            return ListCollection.Remove(item);

            if (this.ItemRemoved != null)
            {
                this.ItemRemoved(this, new ItemRemovedEventArgs<T> { Item = item });
            }
        }

        public bool Contains(T item)
        {
            return ListCollection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ListCollection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ListCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ListCollection.GetEnumerator();
        }
    }
}
