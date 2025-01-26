namespace Nager.Country.Subdivision.SubdivisionInfos;

public class LowerAustriaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Lower Austria";
	public string           TextCode         => "AT-3";
	public SubdivisionCode	Code             => SubdivisionCode.AT3;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}