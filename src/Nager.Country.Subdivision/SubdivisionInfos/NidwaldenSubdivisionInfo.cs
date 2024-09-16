namespace Nager.Country.Subdivision.SubdivisionInfos;

public class NidwaldenSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Nidwalden";
	public string           TextCode         => "CH-NW";
	public SubdivisionCode	Code             => SubdivisionCode.CHNW;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}