namespace Nager.Country.Subdivision.SubdivisionInfos;

public class AppenzellAusserrhodenSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Appenzell Ausserrhoden";
	public string           TextCode         => "CH-AR";
	public SubdivisionCode	Code             => SubdivisionCode.CHAR;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}