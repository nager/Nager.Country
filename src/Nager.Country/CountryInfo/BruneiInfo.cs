namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Brunei
	/// </summary>
	public class BruneiInfo : ICountryInfo
	{
		public string CommonName => "Brunei";
		public string OfficialName => "Nation of Brunei, Abode of Peace";

		public Alpha2Code Alpha2Code => Alpha2Code.BN;
		public Alpha3Code Alpha3Code => Alpha3Code.BRN;
		public int NumericCode => 096;
		public string[] TLD => new [] { ".bn" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.MY,
		};

		public string[] Currencies => new [] { "BND" };
		public string[] CallingCodes => new [] { "673" };
	}
}
