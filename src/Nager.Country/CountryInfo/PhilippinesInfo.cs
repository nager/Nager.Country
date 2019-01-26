namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Philippines
	/// </summary>
	public class PhilippinesInfo : ICountryInfo
	{
		public string CommonName => "Philippines";
		public string OfficialName => "Republic of the Philippines";

		public Alpha2Code Alpha2Code => Alpha2Code.PH;
		public Alpha3Code Alpha3Code => Alpha3Code.PHL;
		public int NumericCode => 608;
		public string[] TLD => new [] { ".ph" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "PHP" };
		public string[] CallingCodes => new [] { "63" };
	}
}
