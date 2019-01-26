namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Malaysia
	/// </summary>
	public class MalaysiaInfo : ICountryInfo
	{
		public string CommonName => "Malaysia";
		public string OfficialName => "Malaysia";

		public Alpha2Code Alpha2Code => Alpha2Code.MY;
		public Alpha3Code Alpha3Code => Alpha3Code.MYS;
		public int NumericCode => 458;
		public string[] TLD => new [] { ".my" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BN,
			Alpha2Code.ID,
			Alpha2Code.TH,
		};

		public string[] Currencies => new [] { "MYR" };
		public string[] CallingCodes => new [] { "60" };
	}
}
