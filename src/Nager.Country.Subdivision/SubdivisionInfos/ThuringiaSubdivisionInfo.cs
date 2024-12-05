namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ThuringiaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Thuringia";
	public string           TextCode         => "DE-TH";
	public SubdivisionCode	Code             => SubdivisionCode.DETH;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}