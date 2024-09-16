namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BurgenlandSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Burgenland";
	public string           TextCode         => "AT-1";
	public SubdivisionCode	Code             => SubdivisionCode.AT1;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}