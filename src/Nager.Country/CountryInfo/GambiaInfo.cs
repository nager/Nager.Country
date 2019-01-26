namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Gambia
	/// </summary>
	public class GambiaInfo : ICountryInfo
	{
		public string CommonName => "Gambia";
		public string OfficialName => "Republic of the Gambia";

		public Alpha2Code Alpha2Code => Alpha2Code.GM;
		public Alpha3Code Alpha3Code => Alpha3Code.GMB;
		public int NumericCode => 270;
		public string[] TLD => new [] { ".gm" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.SN,
		};

		public string[] Currencies => new [] { "GMD" };
		public string[] CallingCodes => new [] { "220" };
	}
}
