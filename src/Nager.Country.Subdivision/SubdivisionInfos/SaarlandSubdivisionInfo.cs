namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SaarlandSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Saarland";
	public string           TextCode         => "DE-SL";
	public SubdivisionCode	Code             => SubdivisionCode.DESL;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}