namespace TTF.Mappings
{
	public class BaseTMappingFunction : IMapping
	{
		public virtual bool IsMatch(bool A, bool B, bool C) => !A && B && C;
		public virtual float Evaluate(int D, int E, int F) => D - (D * F / (float)100);
	}
}