using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
	public class KosovoCountryInfo : ICountryInfo
	{
		public string CommonName => "Kosovo";
		public string OfficialName => "Republic of Kosovo";
		public string NativeName => "Republika e Kosovës";
		public Alpha2Code Alpha2Code => Alpha2Code.XK;     // User-assigned placeholder
		public Alpha3Code Alpha3Code => Alpha3Code.XKX;     // Common unofficial convention
		public int NumericCode => 0;                        // No ISO numeric code yet
		public string[] TLD => new[] { ".xk" };            // Reserved, unofficial
		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;
		public Alpha2Code[] BorderCountries => new[]
		{
			Alpha2Code.AL,
			Alpha2Code.ME,
			Alpha2Code.MK,
			Alpha2Code.RS
		};
		public ICurrency[] Currencies => new[] { new EurCurrency() }; // Euro used unilaterally
		public string[] CallingCodes => new[] { "383" };
	}
}
