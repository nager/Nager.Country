namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Slovenia
	/// </summary>
	public class SloveniaInfo : ICountryInfo
	{
		public string CommonName => "Slovenia";
		public string OfficialName => "Republic of Slovenia";

		public Alpha2Code Alpha2Code => Alpha2Code.SI;
		public Alpha3Code Alpha3Code => Alpha3Code.SVN;
		public int NumericCode => 705;
		public string[] TLD => new [] { ".si" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.HR,
			Alpha2Code.IT,
			Alpha2Code.HU,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "386" };
	}
}
