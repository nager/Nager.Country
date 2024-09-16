namespace Nager.Country.Subdivision.SubdivisionInfos;

public class AppenzellInnerrhodenSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Appenzell Innerrhoden";
	public string           TextCode         => "CH-AI";
	public SubdivisionCode	Code             => SubdivisionCode.CHAI;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}