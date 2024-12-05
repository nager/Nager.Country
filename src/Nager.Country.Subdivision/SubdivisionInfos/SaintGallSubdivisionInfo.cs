namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SaintGallSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Saint Gall";
	public string           TextCode         => "CH-SG";
	public SubdivisionCode	Code             => SubdivisionCode.CHSG;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}