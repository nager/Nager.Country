namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// South Georgia
	/// </summary>
	public class SouthGeorgiaInfo : ICountryInfo
	{
		public string CommonName => "South Georgia";
		public string OfficialName => "South Georgia and the South Sandwich Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.GS;
		public Alpha3Code Alpha3Code => Alpha3Code.SGS;
		public int NumericCode => 239;
		public string[] TLD => new [] { ".gs" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "GBP" };
		public string[] CallingCodes => new [] { "500" };
	}
}
