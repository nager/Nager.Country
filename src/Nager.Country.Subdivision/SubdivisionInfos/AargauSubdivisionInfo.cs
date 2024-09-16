namespace Nager.Country.Subdivision.SubdivisionInfos;

public class AargauSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Aargau";
	public string           TextCode         => "CH-AG";
	public SubdivisionCode	Code             => SubdivisionCode.CHAG;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}