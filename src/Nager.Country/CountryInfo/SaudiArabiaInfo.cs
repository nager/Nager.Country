namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saudi Arabia
	/// </summary>
	public class SaudiArabiaInfo : ICountryInfo
	{
		public string CommonName => "Saudi Arabia";
		public string OfficialName => "Kingdom of Saudi Arabia";

		public Alpha2Code Alpha2Code => Alpha2Code.SA;
		public Alpha3Code Alpha3Code => Alpha3Code.SAU;
		public int NumericCode => 682;
		public string[] TLD => new [] { ".sa", ".السعودية" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IQ,
			Alpha2Code.JO,
			Alpha2Code.KW,
			Alpha2Code.OM,
			Alpha2Code.QA,
			Alpha2Code.AE,
			Alpha2Code.YE,
		};

		public string[] Currencies => new [] { "SAR" };
		public string[] CallingCodes => new [] { "966" };
	}
}
