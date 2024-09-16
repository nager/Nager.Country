namespace Nager.Country.Subdivision.SubdivisionInfos;

public class GenevaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Geneva";
	public string           TextCode         => "CH-GE";
	public SubdivisionCode	Code             => SubdivisionCode.CHGE;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}