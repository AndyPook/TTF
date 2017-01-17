namespace TTF.Mappings
{
	public class Specialized1RMappingFunction : BaseRMappingFunction
	{
		public override float Evaluate(int D, int E, int F) => (2 * D) + (D * E / (float)100);
	}
}