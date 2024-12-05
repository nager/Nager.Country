namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ViennaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Vienna";
	public string           TextCode         => "AT-9";
	public SubdivisionCode	Code             => SubdivisionCode.AT9;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}