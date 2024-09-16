namespace Nager.Country.Subdivision.SubdivisionInfos;

public class JuraSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Jura";
	public string           TextCode         => "CH-JU";
	public SubdivisionCode	Code             => SubdivisionCode.CHJU;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}