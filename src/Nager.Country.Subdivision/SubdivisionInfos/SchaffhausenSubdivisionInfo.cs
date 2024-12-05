namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SchaffhausenSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Schaffhausen";
	public string           TextCode         => "CH-SH";
	public SubdivisionCode	Code             => SubdivisionCode.CHSH;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}