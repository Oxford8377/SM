using System;
using System.Collections.Generic;

namespace PixelCrushers
{
	public static class ListExtensions
	{
		public static void AddSorted<T>(this List<T> @this, T item) where T : IComparable<T>
		{
		}

		public static void Shuffle<T>(this List<T> @this)
		{
		}
	}
}
