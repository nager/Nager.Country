namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bangladesh
	/// </summary>
	public class BangladeshInfo : ICountryInfo
	{
		public string CommonName => "Bangladesh";
		public string OfficialName => "People's Republic of Bangladesh";

		public Alpha2Code Alpha2Code => Alpha2Code.BD;
		public Alpha3Code Alpha3Code => Alpha3Code.BGD;
		public int NumericCode => 050;
		public string[] TLD => new [] { ".bd" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthernAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.MM,
			Alpha2Code.IN,
		};

		public string[] Currencies => new [] { "BDT" };
		public string[] CallingCodes => new [] { "880" };
	}
}
