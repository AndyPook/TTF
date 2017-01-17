namespace TTF
{
	public class MappingEngine
	{
		public MappingEngine(IMapping mapS, IMapping mapR, IMapping mapT)
		{
			MapS = mapS;
			MapR = mapR;
			MapT = mapT;
		}

		public IMapping MapS { get; }
		public IMapping MapR { get; }
		public IMapping MapT { get; }

		public MappingResult Map(bool a, bool b, bool c, int d, int e, int f)
		{
			if (MapS.IsMatch(a, b, c))
				return new MappingResult
				{
					X = MappingType.S,
					Y = MapS.Evaluate(d, e, f)
				};

			if (MapR.IsMatch(a, b, c))
				return new MappingResult
				{
					X = MappingType.R,
					Y = MapR.Evaluate(d, e, f)
				};

			if (MapT.IsMatch(a, b, c))
				return new MappingResult
				{
					X = MappingType.T,
					Y = MapT.Evaluate(d, e, f)
				};

			throw new MappingException("Unknown mapping");
		}
	}
}