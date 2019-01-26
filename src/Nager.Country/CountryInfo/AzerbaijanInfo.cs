namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Azerbaijan
	/// </summary>
	public class AzerbaijanInfo : ICountryInfo
	{
		public string CommonName => "Azerbaijan";
		public string OfficialName => "Republic of Azerbaijan";

		public Alpha2Code Alpha2Code => Alpha2Code.AZ;
		public Alpha3Code Alpha3Code => Alpha3Code.AZE;
		public int NumericCode => 031;
		public string[] TLD => new [] { ".az" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AM,
			Alpha2Code.GE,
			Alpha2Code.IR,
			Alpha2Code.RU,
			Alpha2Code.TR,
		};

		public string[] Currencies => new [] { "AZN" };
		public string[] CallingCodes => new [] { "994" };
	}
}
