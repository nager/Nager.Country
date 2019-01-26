namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Namibia
	/// </summary>
	public class NamibiaInfo : ICountryInfo
	{
		public string CommonName => "Namibia";
		public string OfficialName => "Republic of Namibia";

		public Alpha2Code Alpha2Code => Alpha2Code.NA;
		public Alpha3Code Alpha3Code => Alpha3Code.NAM;
		public int NumericCode => 516;
		public string[] TLD => new [] { ".na" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.SouthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AO,
			Alpha2Code.BW,
			Alpha2Code.ZA,
			Alpha2Code.ZM,
		};

		public string[] Currencies => new [] { "NAD", "ZAR" };
		public string[] CallingCodes => new [] { "264" };
	}
}
