using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class ListOps 
    {
        private List<string> name;
        public ListOps(List<string> _name)
        {
            name = _name;
        }

        public void AddElement(string item)
        {
            name.Add(item);
        }
        public void RemoveElement(string item)
        {
            name.Remove(item);
        }
        public void DisplayElements()
        {
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
        public void SortElements()
        {
            name.Sort();
        }
        public void ReverseElements()
        {
            name.Reverse();
        }
        public void ClearElements()
        {
            name.Clear();
        }
    }
    internal class ListDemo
    {
      
        static void Main()
        {
            var names = new List<string> ();
            ListOps ops = new ListOps(names);
            ops.AddElement("Anshul");
            ops.AddElement("Jasprit");
            ops.AddElement("Siraj");
            ops.AddElement("Shardul");
            ops.AddElement("Rohit");
            Console.WriteLine("Elements in List:");
            ops.DisplayElements();
            ops.RemoveElement("Siraj");
            Console.WriteLine("After removing 'Siraj':");
            ops.DisplayElements();
            ops.SortElements();
            Console.WriteLine("After sorting:");
            ops.DisplayElements();
            ops.ReverseElements();
            Console.WriteLine("After reversing:");
            ops.DisplayElements();
            Console.WriteLine("clearing list");
            ops.ClearElements();
        }
    }
}
