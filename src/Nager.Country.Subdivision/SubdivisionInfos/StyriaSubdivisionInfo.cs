namespace Nager.Country.Subdivision.SubdivisionInfos;

public class StyriaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Styria";
	public string           TextCode         => "AT-6";
	public SubdivisionCode	Code             => SubdivisionCode.AT6;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}