namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Heard Island and McDonald Islands
	/// </summary>
	public class HeardIslandandMcDonaldIslandsInfo : ICountryInfo
	{
		public string CommonName => "Heard Island and McDonald Islands";
		public string OfficialName => "Heard Island and McDonald Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.HM;
		public Alpha3Code Alpha3Code => Alpha3Code.HMD;
		public int NumericCode => 334;
		public string[] TLD => new [] { ".hm", ".aq" };

		public Region Region => Region.None;
		public SubRegion SubRegion => SubRegion.None;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new string[0];
	}
}
