namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Nauru
	/// </summary>
	public class NauruInfo : ICountryInfo
	{
		public string CommonName => "Nauru";
		public string OfficialName => "Republic of Nauru";

		public Alpha2Code Alpha2Code => Alpha2Code.NR;
		public Alpha3Code Alpha3Code => Alpha3Code.NRU;
		public int NumericCode => 520;
		public string[] TLD => new [] { ".nr" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "674" };
	}
}
