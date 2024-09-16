namespace Nager.Country.Subdivision.SubdivisionInfos;

public class FribourgSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Fribourg";
	public string           TextCode         => "CH-FR";
	public SubdivisionCode	Code             => SubdivisionCode.CHFR;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}