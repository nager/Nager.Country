namespace Nager.Country.Subdivision.SubdivisionInfos;

public class HesseSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Hesse";
	public string           TextCode         => "DE-HE";
	public SubdivisionCode	Code             => SubdivisionCode.DEHE;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}