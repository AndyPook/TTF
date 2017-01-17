using TTF.Mappings;

namespace TTF
{
	public class MappingEngineFactory
	{
		public MappingEngine CreateBase()
		{
			return new MappingEngine(
				new BaseSMappingFunction(),
				new BaseRMappingFunction(),
				new BaseTMappingFunction()
			);
		}
		public MappingEngine CreateSpecialized1()
		{
			return new MappingEngine(
				new BaseSMappingFunction(),
				new Specialized1RMappingFunction(),
				new BaseTMappingFunction()
			);
		}
		public MappingEngine CreateSpecialized2()
		{
			return new MappingEngine(
				new Specialized2SMappingFunction(),
				new BaseRMappingFunction(),
				new Specialized2TMappingFunction()
			);
		}
	}
}