using System.Collections.Generic;
using System.Collections;

namespace TTF.Tests
{
	public class TestData : IEnumerable<object[]>
	{
		List<object[]> items = new List<object[]>();

		public void Add(params object[] args)
		{
			items.Add(args);
		}

		public IEnumerator<object[]> GetEnumerator()
		{
			return items.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}