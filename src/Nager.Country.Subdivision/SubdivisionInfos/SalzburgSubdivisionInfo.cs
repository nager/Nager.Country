namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SalzburgSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Salzburg";
	public string           TextCode         => "AT-5";
	public SubdivisionCode	Code             => SubdivisionCode.AT5;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}