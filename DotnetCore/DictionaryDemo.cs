using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class DictionaryDemo
    {
        private Dictionary<string, int> students = new Dictionary<string, int>();

        public void NewDictionaryDemo()
        {
            // Creating a dictionary
            students.Add("sushant", 1);
            students.Add("Atul", 2);
            students.Add("Nitin", 3);
            students.Add("Mishra", 4);

            // Displaying the dictionary entries
            foreach (KeyValuePair<string, int> st in students)
            {
                Console.WriteLine($"name = {st.Key} roll no = {st.Value}");
            }
            // Checking if a key exists
            if (students.ContainsKey("Nitin")) 
            {
                int value = students["Nitin"];
                students.Remove("Nitin");
                students.Add("Nitin madane", value);// Modifying the value associated with the key
            }

            // Displaying the modified dictionary entries
            Console.WriteLine("modified entry");
            foreach (KeyValuePair<string, int> st in students)
            {
                Console.WriteLine($"name = {st.Key} roll no = {st.Value}");
            }

            // Checking if a value exists
            string itemtoremove = null;
            foreach (var Student in students)
            {
                // If the value is 2, we will remove the entry
                if (Student.Value == 2)
                { 
                    itemtoremove = Student.Key;
                }
            }
            // Removing an entry by key
            if (itemtoremove != null)
            {
                students.Remove(itemtoremove);
            }

            // Displaying the dictionary entries after deletion
            Console.WriteLine("deleted entry");
            foreach (KeyValuePair<string, int> st in students)
            {
                Console.WriteLine($"name = {st.Key} roll no = {st.Value}");
            }

            //clering the dictionary
            students.Clear();
            Console.WriteLine("cleared all entries");
        }

        static void Main()
        {
            DictionaryDemo d = new DictionaryDemo();
            d.NewDictionaryDemo();
        }
    }

}
