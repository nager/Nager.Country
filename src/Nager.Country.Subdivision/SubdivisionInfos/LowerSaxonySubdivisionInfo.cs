namespace Nager.Country.Subdivision.SubdivisionInfos;

public class LowerSaxonySubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Lower Saxony";
	public string           TextCode         => "DE-NI";
	public SubdivisionCode	Code             => SubdivisionCode.DENI;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}