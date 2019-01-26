namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Somalia
	/// </summary>
	public class SomaliaInfo : ICountryInfo
	{
		public string CommonName => "Somalia";
		public string OfficialName => "Federal Republic of Somalia";

		public Alpha2Code Alpha2Code => Alpha2Code.SO;
		public Alpha3Code Alpha3Code => Alpha3Code.SOM;
		public int NumericCode => 706;
		public string[] TLD => new [] { ".so" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DJ,
			Alpha2Code.ET,
			Alpha2Code.KE,
		};

		public string[] Currencies => new [] { "SOS" };
		public string[] CallingCodes => new [] { "252" };
	}
}
