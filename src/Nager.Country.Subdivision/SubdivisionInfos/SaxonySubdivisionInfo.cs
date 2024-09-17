namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SaxonySubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Saxony";
	public string           TextCode         => "DE-SN";
	public SubdivisionCode	Code             => SubdivisionCode.DESN;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}