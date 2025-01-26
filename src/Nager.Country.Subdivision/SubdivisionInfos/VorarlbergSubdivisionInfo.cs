namespace Nager.Country.Subdivision.SubdivisionInfos;

public class VorarlbergSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Vorarlberg";
	public string           TextCode         => "AT-8";
	public SubdivisionCode	Code             => SubdivisionCode.AT8;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}