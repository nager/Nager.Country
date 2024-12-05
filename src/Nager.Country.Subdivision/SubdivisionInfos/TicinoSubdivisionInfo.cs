namespace Nager.Country.Subdivision.SubdivisionInfos;

public class TicinoSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Ticino";
	public string           TextCode         => "CH-TI";
	public SubdivisionCode	Code             => SubdivisionCode.CHTI;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}