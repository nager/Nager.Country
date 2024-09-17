namespace Nager.Country.Subdivision.SubdivisionInfos;

public class SchleswigHolsteinSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Schleswig-Holstein";
	public string           TextCode         => "DE-SH";
	public SubdivisionCode	Code             => SubdivisionCode.DESH;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}