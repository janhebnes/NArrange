﻿// <auto-generated /> Disable StyleCop on this file
namespace SampleNamespace
{
	public class AutoPropertyInitializers
	{
		public class Customer
		{
			public string First { get; set; } 
				= "Jane";
			public string Last { get; set; } = "D;oe";
		}

		public class Customer2
		{
			public string First { get; } = "Jane";
			public string Last { get; } = "Doe";
		}

		public class Customer3
		{
			public string Name { get; }

			public Customer3(string first, string last)
	 {
				Name = first + " " + last;
			}
		}

		public class Customer4
		{
			public string First { get; set; }

			public string Last { get; }
			
		}

	}
}