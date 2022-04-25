using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class D3
    {
		public static void Main()
		{
			IDictionary<int, string> numberNames = new Dictionary<int, string>();
			numberNames.Add(1, "One"); //adding key/value using the Add() method
			numberNames.Add(3, "Three");
			numberNames.Add(2, "Two");

			foreach (KeyValuePair<int, string> kvp in numberNames)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

			//creating a dictionary using collection-initializer syntax
			var cities = new Dictionary<string, string>(){
			{"London", "Manchester, Birmingham"},
			{"Chicago", "New York, Washington"},
			{"Mumbai", "New Delhi, Pune"}
		};

			foreach (var kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		}
	}
}
