namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Djibouti
	/// </summary>
	public class DjiboutiInfo : ICountryInfo
	{
		public string CommonName => "Djibouti";
		public string OfficialName => "Republic of Djibouti";

		public Alpha2Code Alpha2Code => Alpha2Code.DJ;
		public Alpha3Code Alpha3Code => Alpha3Code.DJI;
		public int NumericCode => 262;
		public string[] TLD => new [] { ".dj" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ER,
			Alpha2Code.ET,
			Alpha2Code.SO,
		};

		public string[] Currencies => new [] { "DJF" };
		public string[] CallingCodes => new [] { "253" };
	}
}
