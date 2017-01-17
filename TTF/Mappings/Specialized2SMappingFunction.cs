namespace TTF.Mappings
{
	public class Specialized2SMappingFunction : BaseSMappingFunction
	{
		public override bool IsMatch(bool A, bool B, bool C) => A && !B && C;
		public override float Evaluate(int D, int E, int F) => F + D + (D * E / (float)100);
	}
}