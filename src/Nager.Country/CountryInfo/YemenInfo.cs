namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Yemen
	/// </summary>
	public class YemenInfo : ICountryInfo
	{
		public string CommonName => "Yemen";
		public string OfficialName => "Republic of Yemen";

		public Alpha2Code Alpha2Code => Alpha2Code.YE;
		public Alpha3Code Alpha3Code => Alpha3Code.YEM;
		public int NumericCode => 887;
		public string[] TLD => new [] { ".ye" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.OM,
			Alpha2Code.SA,
		};

		public string[] Currencies => new [] { "YER" };
		public string[] CallingCodes => new [] { "967" };
	}
}
