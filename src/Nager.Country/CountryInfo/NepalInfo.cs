namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Nepal
	/// </summary>
	public class NepalInfo : ICountryInfo
	{
		public string CommonName => "Nepal";
		public string OfficialName => "Federal Democratic Republic of Nepal";

		public Alpha2Code Alpha2Code => Alpha2Code.NP;
		public Alpha3Code Alpha3Code => Alpha3Code.NPL;
		public int NumericCode => 524;
		public string[] TLD => new [] { ".np" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthernAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CN,
			Alpha2Code.IN,
		};

		public string[] Currencies => new [] { "NPR" };
		public string[] CallingCodes => new [] { "977" };
	}
}
