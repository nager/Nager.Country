namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BavariaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Bavaria";
	public string           TextCode         => "DE-BY";
	public SubdivisionCode	Code             => SubdivisionCode.DEBY;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}