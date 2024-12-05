namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BadenWuerttembergSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Baden-Wuerttemberg";
	public string           TextCode         => "DE-BW";
	public SubdivisionCode	Code             => SubdivisionCode.DEBW;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}