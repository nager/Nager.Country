namespace Nager.Country.Subdivision.SubdivisionInfos;

public class ThurgauSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Thurgau";
	public string           TextCode         => "CH-TG";
	public SubdivisionCode	Code             => SubdivisionCode.CHTG;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}