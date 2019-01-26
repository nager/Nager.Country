namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Liberia
	/// </summary>
	public class LiberiaInfo : ICountryInfo
	{
		public string CommonName => "Liberia";
		public string OfficialName => "Republic of Liberia";

		public Alpha2Code Alpha2Code => Alpha2Code.LR;
		public Alpha3Code Alpha3Code => Alpha3Code.LBR;
		public int NumericCode => 430;
		public string[] TLD => new [] { ".lr" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GN,
			Alpha2Code.CI,
			Alpha2Code.SL,
		};

		public string[] Currencies => new [] { "LRD" };
		public string[] CallingCodes => new [] { "231" };
	}
}
