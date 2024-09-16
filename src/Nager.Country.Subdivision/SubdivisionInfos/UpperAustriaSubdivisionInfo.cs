namespace Nager.Country.Subdivision.SubdivisionInfos;

public class UpperAustriaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Upper Austria";
	public string           TextCode         => "AT-4";
	public SubdivisionCode	Code             => SubdivisionCode.AT4;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}