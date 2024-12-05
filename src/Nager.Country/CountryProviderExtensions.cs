namespace Nager.Country;

public static class CountryProviderExtensions
{
	public static IEnumerable<ICountryInfo> GetCountriesByRegion( this ICountryProvider provider, Region region )
	{
		return provider.GetCountries().Where( x => x.Region == region );
	}

	public static IEnumerable<ICountryInfo> GetCountriesBySubRegion( this ICountryProvider provider,
		SubRegion subRegion )
	{
		return provider.GetCountries().Where( x => x.SubRegion == subRegion );
	}
}