namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BerlinSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Berlin";
	public string           TextCode         => "DE-BE";
	public SubdivisionCode	Code             => SubdivisionCode.DEBE;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}