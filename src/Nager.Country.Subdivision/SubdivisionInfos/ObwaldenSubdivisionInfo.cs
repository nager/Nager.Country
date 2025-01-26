namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ObwaldenSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Obwalden";
	public string           TextCode         => "CH-OW";
	public SubdivisionCode	Code             => SubdivisionCode.CHOW;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}