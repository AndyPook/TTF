namespace TTF.Mappings
{
	public class Specialized2TMappingFunction : BaseTMappingFunction
	{
		public override bool IsMatch(bool A, bool B, bool C) => A && B && !C;
	}
}