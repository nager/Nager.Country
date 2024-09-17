namespace Nager.Country.Subdivision.SubdivisionInfos;

public class NorthRhineWestphaliaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "North Rhine-Westphalia";
	public string           TextCode         => "DE-NW";
	public SubdivisionCode	Code             => SubdivisionCode.DENW;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}