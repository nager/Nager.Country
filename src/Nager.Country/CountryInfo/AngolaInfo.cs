namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Angola
	/// </summary>
	public class AngolaInfo : ICountryInfo
	{
		public string CommonName => "Angola";
		public string OfficialName => "Republic of Angola";

		public Alpha2Code Alpha2Code => Alpha2Code.AO;
		public Alpha3Code Alpha3Code => Alpha3Code.AGO;
		public int NumericCode => 024;
		public string[] TLD => new [] { ".ao" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CG,
			Alpha2Code.CD,
			Alpha2Code.ZM,
			Alpha2Code.NA,
		};

		public string[] Currencies => new [] { "AOA" };
		public string[] CallingCodes => new [] { "244" };
	}
}
