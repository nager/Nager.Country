namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bosnia and Herzegovina
	/// </summary>
	public class BosniaandHerzegovinaInfo : ICountryInfo
	{
		public string CommonName => "Bosnia and Herzegovina";
		public string OfficialName => "Bosnia and Herzegovina";

		public Alpha2Code Alpha2Code => Alpha2Code.BA;
		public Alpha3Code Alpha3Code => Alpha3Code.BIH;
		public int NumericCode => 070;
		public string[] TLD => new [] { ".ba" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.HR,
			Alpha2Code.ME,
			Alpha2Code.RS,
		};

		public string[] Currencies => new [] { "BAM" };
		public string[] CallingCodes => new [] { "387" };
	}
}
