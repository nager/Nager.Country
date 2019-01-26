namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United Kingdom
	/// </summary>
	public class UnitedKingdomInfo : ICountryInfo
	{
		public string CommonName => "United Kingdom";
		public string OfficialName => "United Kingdom of Great Britain and Northern Ireland";

		public Alpha2Code Alpha2Code => Alpha2Code.GB;
		public Alpha3Code Alpha3Code => Alpha3Code.GBR;
		public int NumericCode => 826;
		public string[] TLD => new [] { ".uk" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IE,
		};

		public string[] Currencies => new [] { "GBP" };
		public string[] CallingCodes => new [] { "44" };
	}
}
