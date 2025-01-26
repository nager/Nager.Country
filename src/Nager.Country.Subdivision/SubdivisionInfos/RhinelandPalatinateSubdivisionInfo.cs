namespace Nager.Country.Subdivision.SubdivisionInfos;

public class RhinelandPalatinateSubdivisionInfo : ISubdivisionInfo
{
	public string           CommonName       => "Rhineland-Palatinate";
	public string           TextCode         => "DE-RP";
	public SubdivisionCode	Code             => SubdivisionCode.DERP;
	public Alpha2Code       ParentAlpha2Code => Alpha2Code.DE;
}