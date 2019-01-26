namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Ghana
	/// </summary>
	public class GhanaInfo : ICountryInfo
	{
		public string CommonName => "Ghana";
		public string OfficialName => "Republic of Ghana";

		public Alpha2Code Alpha2Code => Alpha2Code.GH;
		public Alpha3Code Alpha3Code => Alpha3Code.GHA;
		public int NumericCode => 288;
		public string[] TLD => new [] { ".gh" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BF,
			Alpha2Code.CI,
			Alpha2Code.TG,
		};

		public string[] Currencies => new [] { "GHS" };
		public string[] CallingCodes => new [] { "233" };
	}
}
