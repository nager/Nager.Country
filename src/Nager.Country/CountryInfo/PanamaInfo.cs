namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Panama
	/// </summary>
	public class PanamaInfo : ICountryInfo
	{
		public string CommonName => "Panama";
		public string OfficialName => "Republic of Panama";

		public Alpha2Code Alpha2Code => Alpha2Code.PA;
		public Alpha3Code Alpha3Code => Alpha3Code.PAN;
		public int NumericCode => 591;
		public string[] TLD => new [] { ".pa" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CO,
			Alpha2Code.CR,
		};

		public string[] Currencies => new [] { "PAB", "USD" };
		public string[] CallingCodes => new [] { "507" };
	}
}
