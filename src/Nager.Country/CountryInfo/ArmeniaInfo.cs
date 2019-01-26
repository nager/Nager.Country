namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Armenia
	/// </summary>
	public class ArmeniaInfo : ICountryInfo
	{
		public string CommonName => "Armenia";
		public string OfficialName => "Republic of Armenia";

		public Alpha2Code Alpha2Code => Alpha2Code.AM;
		public Alpha3Code Alpha3Code => Alpha3Code.ARM;
		public int NumericCode => 051;
		public string[] TLD => new [] { ".am" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AZ,
			Alpha2Code.GE,
			Alpha2Code.IR,
			Alpha2Code.TR,
		};

		public string[] Currencies => new [] { "AMD" };
		public string[] CallingCodes => new [] { "374" };
	}
}
