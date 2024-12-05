namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ValaisSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Valais";
	public string           TextCode         => "CH-VS";
	public SubdivisionCode	Code             => SubdivisionCode.CHVS;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}