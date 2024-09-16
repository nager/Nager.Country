namespace Nager.Country.Subdivision.SubdivisionInfos;

public class CarinthiaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Carinthia";
	public string           TextCode         => "AT-2";
	public SubdivisionCode	Code             => SubdivisionCode.AT2;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.AT;
}