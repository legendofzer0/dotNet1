using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	public class MyDictionary<TKey, TValue>
	{
		private Dictionary<TKey, TValue> dictionary;

		public MyDictionary()
		{
			dictionary = new Dictionary<TKey, TValue>();
		}

		// Add a key-value pair to the dictionary
		public void Add(TKey key, TValue value)
		{
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, value);
			}
			else
			{
				Console.WriteLine("Key already exists.");
			}
		}

		// Retrieve value by key
		public TValue Get(TKey key)
		{
			if (dictionary.ContainsKey(key))
			{
				return dictionary[key];
			}
			else
			{
				Console.WriteLine("Key not found.");
				return default(TValue);
			}
		}

		// Display all key-value pairs in the dictionary
		public void DisplayAll()
		{
			foreach (var kvp in dictionary)
			{
				Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
			}
		}
	}

}
