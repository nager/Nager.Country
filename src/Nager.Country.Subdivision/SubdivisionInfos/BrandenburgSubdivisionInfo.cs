namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BrandenburgSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Brandenburg";
	public string           TextCode         => "DE-BB";
	public SubdivisionCode	Code             => SubdivisionCode.DEBB;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}