namespace Nager.Country.Subdivision;

public interface ISubdivisionProvider
{
	IEnumerable<ISubdivisionInfo> GetSubdivisions();
	IEnumerable<ISubdivisionInfo> GetSubdivisions( Alpha2Code alpha2Code );
	IEnumerable<ISubdivisionInfo> GetSubdivisions( Alpha3Code alpha3Code );
	
	ISubdivisionInfo GetSubdivision( SubdivisionCode code );
}