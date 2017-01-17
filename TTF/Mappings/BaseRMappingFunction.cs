namespace TTF.Mappings
{
	public class BaseRMappingFunction : IMapping
	{
		public virtual bool IsMatch(bool A, bool B, bool C) => A && B && C;
		public virtual float Evaluate(int D, int E, int F) => D + (D * (E - F) / (float)100);
	}
}