namespace Nager.Country.Subdivision.SubdivisionInfos;

public class HamburgSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Hamburg";
	public string           TextCode         => "DE-HH";
	public SubdivisionCode	Code             => SubdivisionCode.DEHH;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}