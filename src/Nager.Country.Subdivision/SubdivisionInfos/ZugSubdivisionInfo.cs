namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ZugSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Zug";
	public string           TextCode         => "CH-ZG";
	public SubdivisionCode	Code             => SubdivisionCode.CHZG;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}