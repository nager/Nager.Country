namespace Nager.Country.Subdivision.SubdivisionInfos;

public class BremenSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Bremen";
	public string           TextCode         => "DE-HB";
	public SubdivisionCode	Code             => SubdivisionCode.DEHB;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}