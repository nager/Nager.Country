namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Zimbabwe
	/// </summary>
	public class ZimbabweInfo : ICountryInfo
	{
		public string CommonName => "Zimbabwe";
		public string OfficialName => "Republic of Zimbabwe";

		public Alpha2Code Alpha2Code => Alpha2Code.ZW;
		public Alpha3Code Alpha3Code => Alpha3Code.ZWE;
		public int NumericCode => 716;
		public string[] TLD => new [] { ".zw" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BW,
			Alpha2Code.MZ,
			Alpha2Code.ZA,
			Alpha2Code.ZM,
		};

		public string[] Currencies => new [] { "ZWL" };
		public string[] CallingCodes => new [] { "263" };
	}
}
