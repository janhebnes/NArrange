﻿// <auto-generated /> Disable StyleCop on this file
using System;

namespace SampleNamespace
{
	public class ExpressionBodies
	{
		/// <summary>
		/// Class containing expression bodies on method-like members.
		/// </summary>
		public class Vector
		{
			public int X;
			public int Y;

			public Vector(int x, int y)
			{
				X = x;
				Y = y;
			}

			/// <summary>
			/// This method adds two vectors.
			/// </summary>
			/// <param name="other"></param>
			/// <returns></returns>
			public Vector Add(Vector other)
			{
				return new Vector(X + other.X, Y + other.Y);
			}

			/// <summary>
			/// This is a comment.
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <returns></returns>
			public static Vector operator +(Vector a, Vector b) => a.Add(b);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="p"></param>
			/// <returns></returns>
			public static implicit operator string (Vector p) => p.X + " " + p.Y;

			/// <summary>
			/// 
			/// </summary>
			/// <param name="dx"></param>
			/// <param name="dy"></param>
			/// <returns></returns>
			public Vector Move(int dx, int dy) => new Vector(X + dx, X + dy);


			/// <summary>
			/// Prints the vector to console.
			/// </summary>
			public void Print() => Console.WriteLine(X + " " + Y);
		}

		/// <summary>
		/// Class containing expression bodies on property-like members.
		/// </summary>
		public class Customer
		{
			public string First { get; set; } = "Jane";
			public string Last { get; set; } = "Doe";

			public string Name => First + " " + Last;
			public Customer this[long id] => LookupCustomer(id);

			private Customer LookupCustomer(long id)
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Class containing expression bodies on property-like members that are get-only.
		/// </summary>
		public class Customer2
		{
			public string First { get; } = "Jane";
			public string Last { get; } = "Doe";

			public string Name => First + " " + Last;
			public Customer this[long id] => LookupCustomer(id);

			/// <summary>
			/// nameof is also a new keyword that can be used in an expression.
			/// </summary>
			public string PropertyName => nameof(PropertyName);

			private Customer LookupCustomer(long id)
			{
				throw new NotImplementedException();
			}
		}
	}
}