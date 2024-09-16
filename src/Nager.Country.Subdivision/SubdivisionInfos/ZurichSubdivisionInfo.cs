namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ZurichSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Zurich";
	public string           TextCode         => "CH-ZH";
	public SubdivisionCode	Code             => SubdivisionCode.CHZH;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}