namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Timor-Leste
	/// </summary>
	public class TimorLesteInfo : ICountryInfo
	{
		public string CommonName => "Timor-Leste";
		public string OfficialName => "Democratic Republic of Timor-Leste";

		public Alpha2Code Alpha2Code => Alpha2Code.TL;
		public Alpha3Code Alpha3Code => Alpha3Code.TLS;
		public int NumericCode => 626;
		public string[] TLD => new [] { ".tl" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ID,
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "670" };
	}
}
