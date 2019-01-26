namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Tanzania
	/// </summary>
	public class TanzaniaInfo : ICountryInfo
	{
		public string CommonName => "Tanzania";
		public string OfficialName => "United Republic of Tanzania";

		public Alpha2Code Alpha2Code => Alpha2Code.TZ;
		public Alpha3Code Alpha3Code => Alpha3Code.TZA;
		public int NumericCode => 834;
		public string[] TLD => new [] { ".tz" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BI,
			Alpha2Code.CD,
			Alpha2Code.KE,
			Alpha2Code.MW,
			Alpha2Code.MZ,
			Alpha2Code.RW,
			Alpha2Code.UG,
			Alpha2Code.ZM,
		};

		public string[] Currencies => new [] { "TZS" };
		public string[] CallingCodes => new [] { "255" };
	}
}
