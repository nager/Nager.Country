namespace Nager.Country.Subdivision.SubdivisionInfos;

public class NeuchatelSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Neuchatel";
	public string           TextCode         => "CH-NE";
	public SubdivisionCode	Code             => SubdivisionCode.CHNE;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}