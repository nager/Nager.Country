namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BaselCitySubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Basel-City";
	public string           TextCode         => "CH-BS";
	public SubdivisionCode	Code             => SubdivisionCode.CHBS;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}