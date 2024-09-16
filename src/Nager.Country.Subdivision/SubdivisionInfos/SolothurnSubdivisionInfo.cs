namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SolothurnSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Solothurn";
	public string           TextCode         => "CH-SO";
	public SubdivisionCode	Code             => SubdivisionCode.CHSO;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}