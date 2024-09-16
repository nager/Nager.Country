namespace Nager.Country.Subdivision.SubdivisionInfos;

public class UriSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Uri";
	public string           TextCode         => "CH-UR";
	public SubdivisionCode	Code             => SubdivisionCode.CHUR;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}