using Xunit;

using TTF.Mappings;

namespace TTF.Tests
{
	public class MappingEngineFactoryTests
	{
		[Fact]
		public void CorrectMappingsAreChosenForBase()
		{
			var factory = new MappingEngineFactory();

			var engine = factory.CreateBase();

			Assert.True(engine.MapS.GetType() == typeof(BaseSMappingFunction));
			Assert.True(engine.MapR.GetType() == typeof(BaseRMappingFunction));
			Assert.True(engine.MapT.GetType() == typeof(BaseTMappingFunction));
		}

		[Fact]
		public void CorrectMappingsAreChosenForSpecialized1()
		{
			var factory = new MappingEngineFactory();

			var engine = factory.CreateSpecialized1();

			Assert.True(engine.MapS.GetType() == typeof(BaseSMappingFunction));
			Assert.True(engine.MapR.GetType() == typeof(Specialized1RMappingFunction));
			Assert.True(engine.MapT.GetType() == typeof(BaseTMappingFunction));
		}

		[Fact]
		public void CorrectMappingsAreChosenForSpecialized2()
		{
			var factory = new MappingEngineFactory();

			var engine = factory.CreateSpecialized2();

			Assert.True(engine.MapS.GetType() == typeof(Specialized2SMappingFunction));
			Assert.True(engine.MapR.GetType() == typeof(BaseRMappingFunction));
			Assert.True(engine.MapT.GetType() == typeof(Specialized2TMappingFunction));
		}
	}
}
