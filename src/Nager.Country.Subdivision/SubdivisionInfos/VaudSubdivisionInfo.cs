namespace Nager.Country.Subdivision.SubdivisionInfos;

public class VaudSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Vaud";
	public string           TextCode         => "CH-VD";
	public SubdivisionCode	Code             => SubdivisionCode.CHVD;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}