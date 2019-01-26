namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Equatorial Guinea
	/// </summary>
	public class EquatorialGuineaInfo : ICountryInfo
	{
		public string CommonName => "Equatorial Guinea";
		public string OfficialName => "Republic of Equatorial Guinea";

		public Alpha2Code Alpha2Code => Alpha2Code.GQ;
		public Alpha3Code Alpha3Code => Alpha3Code.GNQ;
		public int NumericCode => 226;
		public string[] TLD => new [] { ".gq" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CM,
			Alpha2Code.GA,
		};

		public string[] Currencies => new [] { "XAF" };
		public string[] CallingCodes => new [] { "240" };
	}
}
