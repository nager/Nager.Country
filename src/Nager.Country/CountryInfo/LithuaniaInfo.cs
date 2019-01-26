namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Lithuania
	/// </summary>
	public class LithuaniaInfo : ICountryInfo
	{
		public string CommonName => "Lithuania";
		public string OfficialName => "Republic of Lithuania";

		public Alpha2Code Alpha2Code => Alpha2Code.LT;
		public Alpha3Code Alpha3Code => Alpha3Code.LTU;
		public int NumericCode => 440;
		public string[] TLD => new [] { ".lt" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BY,
			Alpha2Code.LV,
			Alpha2Code.PL,
			Alpha2Code.RU,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "370" };
	}
}
