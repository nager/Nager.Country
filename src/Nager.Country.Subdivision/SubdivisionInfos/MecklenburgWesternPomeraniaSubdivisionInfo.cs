namespace Nager.Country.Subdivision.SubdivisionInfos;

public class MecklenburgWesternPomeraniaSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Mecklenburg-Western Pomerania";
	public string           TextCode         => "DE-MV";
	public SubdivisionCode	Code             => SubdivisionCode.DEMV;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}