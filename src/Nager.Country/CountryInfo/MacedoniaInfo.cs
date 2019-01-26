namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Macedonia
	/// </summary>
	public class MacedoniaInfo : ICountryInfo
	{
		public string CommonName => "Macedonia";
		public string OfficialName => "Republic of Macedonia";

		public Alpha2Code Alpha2Code => Alpha2Code.MK;
		public Alpha3Code Alpha3Code => Alpha3Code.MKD;
		public int NumericCode => 807;
		public string[] TLD => new [] { ".mk" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AL,
			Alpha2Code.BG,
			Alpha2Code.GR,
			Alpha2Code.RS,
		};

		public string[] Currencies => new [] { "MKD" };
		public string[] CallingCodes => new [] { "389" };
	}
}
