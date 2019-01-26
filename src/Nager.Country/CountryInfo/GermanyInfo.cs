namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Germany
	/// </summary>
	public class GermanyInfo : ICountryInfo
	{
		public string CommonName => "Germany";
		public string OfficialName => "Federal Republic of Germany";

		public Alpha2Code Alpha2Code => Alpha2Code.DE;
		public Alpha3Code Alpha3Code => Alpha3Code.DEU;
		public int NumericCode => 276;
		public string[] TLD => new [] { ".de" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.WesternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.BE,
			Alpha2Code.CZ,
			Alpha2Code.DK,
			Alpha2Code.FR,
			Alpha2Code.LU,
			Alpha2Code.NL,
			Alpha2Code.PL,
			Alpha2Code.CH,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "49" };
	}
}
