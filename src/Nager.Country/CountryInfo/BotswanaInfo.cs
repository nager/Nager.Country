namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Botswana
	/// </summary>
	public class BotswanaInfo : ICountryInfo
	{
		public string CommonName => "Botswana";
		public string OfficialName => "Republic of Botswana";

		public Alpha2Code Alpha2Code => Alpha2Code.BW;
		public Alpha3Code Alpha3Code => Alpha3Code.BWA;
		public int NumericCode => 072;
		public string[] TLD => new [] { ".bw" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.SouthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.NA,
			Alpha2Code.ZA,
			Alpha2Code.ZM,
			Alpha2Code.ZW,
		};

		public string[] Currencies => new [] { "BWP" };
		public string[] CallingCodes => new [] { "267" };
	}
}
