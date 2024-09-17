namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SaxonyAnhaltSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Saxony-Anhalt";
	public string           TextCode         => "DE-ST";
	public SubdivisionCode	Code             => SubdivisionCode.DEST;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}