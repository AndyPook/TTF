using Xunit;
using TTF.Mappings;

namespace TTF.Tests
{
	public class MappingIsMatchTests
	{
		public static TestData TestData => GenerateTestData();

		private static TestData GenerateTestData()
		{
			var result = new TestData();

			// generate the combinations of a,b,c indicating which values should match each mapping
			GenerateTestDataForMapping(result, new BaseSMappingFunction(), true, true, false);
			GenerateTestDataForMapping(result, new BaseRMappingFunction(), true, true, true);
			GenerateTestDataForMapping(result, new BaseTMappingFunction(), false, true, true);

			GenerateTestDataForMapping(result, new Specialized1RMappingFunction(), true, true, true);

			GenerateTestDataForMapping(result, new Specialized2SMappingFunction(), true, false, true);
			GenerateTestDataForMapping(result, new Specialized2TMappingFunction(), true, true, false);

			return result;
		}

		private static void GenerateTestDataForMapping(TestData testData, IMapping mapping, bool shouldA, bool shouldB, bool shouldC)
		{
			// generate all possible combinations of a,b,c
			for (int i = 0; i <= 7; i++)
			{
				bool a = (i ^ 1) == 1;
				bool b = (i ^ 2) == 2;
				bool c = (i ^ 4) == 4;

				// the combination of a,b,c that should match the mapping
				bool shouldMatch =
					a == shouldA &&
					b == shouldB &&
					c == shouldC;

				testData.Add(mapping, a, b, c, shouldMatch);
			}
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void IsMatch(IMapping mapping, bool a, bool b, bool c, bool isMatch)
		{
			var result = mapping.IsMatch(a, b, c);

			Assert.Equal(isMatch, result);
		}
	}
}