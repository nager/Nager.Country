namespace Nager.Country.Subdivision.SubdivisionInfos;

public class GrisonsSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Grisons";
	public string           TextCode         => "CH-GR";
	public SubdivisionCode	Code             => SubdivisionCode.CHGR;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}