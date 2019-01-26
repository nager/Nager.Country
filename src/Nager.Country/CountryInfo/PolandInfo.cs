namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Poland
	/// </summary>
	public class PolandInfo : ICountryInfo
	{
		public string CommonName => "Poland";
		public string OfficialName => "Republic of Poland";

		public Alpha2Code Alpha2Code => Alpha2Code.PL;
		public Alpha3Code Alpha3Code => Alpha3Code.POL;
		public int NumericCode => 616;
		public string[] TLD => new [] { ".pl" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BY,
			Alpha2Code.CZ,
			Alpha2Code.DE,
			Alpha2Code.LT,
			Alpha2Code.RU,
			Alpha2Code.SK,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "PLN" };
		public string[] CallingCodes => new [] { "48" };
	}
}
