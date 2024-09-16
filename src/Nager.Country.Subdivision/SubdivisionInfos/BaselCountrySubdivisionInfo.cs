namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BaselCountrySubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Basel-Country";
	public string           TextCode         => "CH-BL";
	public SubdivisionCode	Code             => SubdivisionCode.CHBL;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}