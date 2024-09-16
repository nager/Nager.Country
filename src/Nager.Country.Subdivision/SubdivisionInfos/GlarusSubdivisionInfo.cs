namespace Nager.Country.Subdivision.SubdivisionInfos;

public class GlarusSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Glarus";
	public string           TextCode         => "CH-GL";
	public SubdivisionCode	Code             => SubdivisionCode.CHGL;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.CH;
}