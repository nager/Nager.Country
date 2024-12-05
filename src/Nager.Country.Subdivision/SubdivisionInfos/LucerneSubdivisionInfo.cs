namespace Nager.Country.Subdivision.SubdivisionInfos;

public class LucerneSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Lucerne";
	public string           TextCode         => "CH-LU";
	public SubdivisionCode	Code             => SubdivisionCode.CHLU;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}