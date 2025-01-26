namespace Nager.Country.Subdivision;

public class SubdivisionProvider : ISubdivisionProvider
{
	private readonly Dictionary<Alpha2Code, ISubdivisionInfo[]>    _alpha2Code2SubdivisionInfos;
	private readonly Dictionary<SubdivisionCode, ISubdivisionInfo> _code2SubdivisionInfo;

	public SubdivisionProvider()
	{
		_code2SubdivisionInfo = SubdivisionProviderInitializer.Create();

		// generate alpha 2 infos
		_alpha2Code2SubdivisionInfos = _code2SubdivisionInfo
			.GroupBy( entry => entry.Value.ParentAlpha2Code )
			.ToDictionary( group => group.Key, entry => entry.Select( info => info.Value ).ToArray() );
	}

	public IEnumerable<ISubdivisionInfo> GetSubdivisions()
	{
		return _alpha2Code2SubdivisionInfos.Values.SelectMany( x => x );
	}

	public IEnumerable<ISubdivisionInfo> GetSubdivisions( Alpha2Code alpha2Code )
	{
		if( _alpha2Code2SubdivisionInfos.TryGetValue( alpha2Code, out ISubdivisionInfo[] subdivisions ) )
		{
			return subdivisions;
		}

		return [];
	}

	public IEnumerable<ISubdivisionInfo> GetSubdivisions( Alpha3Code alpha3Code )
	{
		return GetSubdivisions( alpha3Code.ToAlpha2Code() );
	}

	public ISubdivisionInfo GetSubdivision( SubdivisionCode code )
	{
		if( _code2SubdivisionInfo.TryGetValue( code, out ISubdivisionInfo value ) )
		{
			return value;
		}

		throw new UnknownSubdivisionException( $"Cannot found subdivision for code {code}" );
	}
}