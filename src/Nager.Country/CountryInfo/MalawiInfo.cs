namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Malawi
	/// </summary>
	public class MalawiInfo : ICountryInfo
	{
		public string CommonName => "Malawi";
		public string OfficialName => "Republic of Malawi";

		public Alpha2Code Alpha2Code => Alpha2Code.MW;
		public Alpha3Code Alpha3Code => Alpha3Code.MWI;
		public int NumericCode => 454;
		public string[] TLD => new [] { ".mw" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.MZ,
			Alpha2Code.TZ,
			Alpha2Code.ZM,
		};

		public string[] Currencies => new [] { "MWK" };
		public string[] CallingCodes => new [] { "265" };
	}
}
