namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Slovakia
	/// </summary>
	public class SlovakiaInfo : ICountryInfo
	{
		public string CommonName => "Slovakia";
		public string OfficialName => "Slovak Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.SK;
		public Alpha3Code Alpha3Code => Alpha3Code.SVK;
		public int NumericCode => 703;
		public string[] TLD => new [] { ".sk" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.CZ,
			Alpha2Code.HU,
			Alpha2Code.PL,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "421" };
	}
}
