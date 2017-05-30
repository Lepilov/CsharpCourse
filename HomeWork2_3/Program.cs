using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var superList = new SuperList<string>();

            superList.ItemAdding += (sender, e) => Console.WriteLine($"Произошло событие перед добавлением элемента {e.Item}");
            superList.ItemAdded += (sender, e) => Console.WriteLine($"Добавлен элемент {e.Item}");
            superList.Add("Первый элемент");
            superList.Add("Второй элемент");
            superList.Add("Третий элемент");
            Console.WriteLine("Список элементов: ");
            foreach (var item in superList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Кол-во элементов: { superList.Count }");

            superList.ItemRemoving += (sender, e) => Console.WriteLine($"Произошло событие перед удалением элемента {e.Item}");
            superList.ItemAdded += (sender, e) => Console.WriteLine($"Элемент удален {e.Item}");
            superList.Remove(superList.ElementAt(0));
            Console.WriteLine("Список элементов: ");
            foreach (var item in superList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Кол-во элементов: { superList.Count }");

            superList.ListClearing += (sender, e) => Console.WriteLine($"Произошло событие перед очитской списка");
            superList.ItemAdded += (sender, e) => Console.WriteLine($"Список очищен");
            superList.Clear();
            Console.WriteLine($"Кол-во элементов: { superList.Count }");

            superList.ItemAdding += (sender, e) => e.Cancel = true;
            superList.Add("1");
        }
    }
}
