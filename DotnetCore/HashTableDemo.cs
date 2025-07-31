using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class HashTableOps
    {
        Hashtable table = new Hashtable();
        public void addElement(object key, object value)
        {
            if (!table.ContainsKey(key))
            {
                table.Add(key, value);
            }
            else
            {
                Console.WriteLine($"Key '{key}' already exists.");
            }
        }
        public void removeElement(object key)
        {
            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                Console.WriteLine($"Key '{key}' does not exist.");
            }
        }
        public void displayElements()
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

    }

    internal class HashTableDemo
    {
        static void Main()
        {
            HashTableOps hashTableOps = new HashTableOps();
            hashTableOps.addElement("Name", "John Doe");
            hashTableOps.addElement("Age", 30);
            hashTableOps.addElement("Country", "USA");
            hashTableOps.displayElements();
            Console.WriteLine("Removing 'Age' key:");
            hashTableOps.removeElement("Age");
            hashTableOps.displayElements();
            Console.WriteLine("Trying to remove non-existing key 'City':");
            hashTableOps.removeElement("City");
            Console.WriteLine("Adding existing key 'Name':");
            hashTableOps.addElement("Name", "Jane Doe");
        }
    }
}
