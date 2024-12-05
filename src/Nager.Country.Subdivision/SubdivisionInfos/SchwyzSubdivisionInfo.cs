namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SchwyzSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Schwyz";
	public string           TextCode         => "CH-SZ";
	public SubdivisionCode	Code             => SubdivisionCode.CHSZ;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}