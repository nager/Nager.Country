namespace Nager.Country.Subdivision;

public static class SubdivisionProviderExtensions
{
	public static IEnumerable<ISubdivisionInfo> GetSubdivisions( this ISubdivisionProvider provider,
		ICountryInfo country )
	{
		return provider.GetSubdivisions( country.Alpha2Code );
	}
	
	public static ISubdivisionInfo GetSubdivision( this ISubdivisionProvider provider, string code )
	{
		if( TryGetSubdivision( provider, code, out ISubdivisionInfo subdivision ) )
		{
			return subdivision;
		}
		
		throw new UnknownSubdivisionException( $"Cannot found a subdivision for code {code}" );
	}
	
	public static bool TryGetSubdivision( this ISubdivisionProvider provider, string code, out ISubdivisionInfo subdivision )
	{
		if( Enum.TryParse( code, true, out SubdivisionCode subdivisionCode ) )
		{
			subdivision = provider.GetSubdivision( subdivisionCode );
			return true;
		}

		subdivision = null;
		return false;
	}

	public static ISubdivisionInfo GetSubdivisionByName( this ISubdivisionProvider provider, string subdivisionName )
	{
		foreach( var subdivisionInfo in provider.GetSubdivisions() )
		{
			if( subdivisionInfo.CommonName.Equals( subdivisionName, StringComparison.OrdinalIgnoreCase ) )
			{
				return subdivisionInfo;
			}
		}
		
		throw new UnknownSubdivisionException( $"Cannot found a subdivision for subdivisionName {subdivisionName}" );
	}
}