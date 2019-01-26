namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Nigeria
	/// </summary>
	public class NigeriaInfo : ICountryInfo
	{
		public string CommonName => "Nigeria";
		public string OfficialName => "Federal Republic of Nigeria";

		public Alpha2Code Alpha2Code => Alpha2Code.NG;
		public Alpha3Code Alpha3Code => Alpha3Code.NGA;
		public int NumericCode => 566;
		public string[] TLD => new [] { ".ng" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BJ,
			Alpha2Code.CM,
			Alpha2Code.TD,
			Alpha2Code.NE,
		};

		public string[] Currencies => new [] { "NGN" };
		public string[] CallingCodes => new [] { "234" };
	}
}
