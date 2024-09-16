namespace Nager.Country.Subdivision.SubdivisionInfos;

public class TyrolSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Tyrol";
	public string           TextCode         => "AT-7";
	public SubdivisionCode	Code             => SubdivisionCode.AT7;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}