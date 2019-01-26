namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mozambique
	/// </summary>
	public class MozambiqueInfo : ICountryInfo
	{
		public string CommonName => "Mozambique";
		public string OfficialName => "Republic of Mozambique";

		public Alpha2Code Alpha2Code => Alpha2Code.MZ;
		public Alpha3Code Alpha3Code => Alpha3Code.MOZ;
		public int NumericCode => 508;
		public string[] TLD => new [] { ".mz" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.MW,
			Alpha2Code.ZA,
			Alpha2Code.SZ,
			Alpha2Code.TZ,
			Alpha2Code.ZM,
			Alpha2Code.ZW,
		};

		public string[] Currencies => new [] { "MZN" };
		public string[] CallingCodes => new [] { "258" };
	}
}
