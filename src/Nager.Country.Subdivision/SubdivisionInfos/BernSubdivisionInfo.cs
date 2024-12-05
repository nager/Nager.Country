namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BernSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Bern";
	public string           TextCode         => "CH-BE";
	public SubdivisionCode	Code             => SubdivisionCode.CHBE;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}