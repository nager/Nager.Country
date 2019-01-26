namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Guernsey
	/// </summary>
	public class GuernseyInfo : ICountryInfo
	{
		public string CommonName => "Guernsey";
		public string OfficialName => "Bailiwick of Guernsey";

		public Alpha2Code Alpha2Code => Alpha2Code.GG;
		public Alpha3Code Alpha3Code => Alpha3Code.GGY;
		public int NumericCode => 831;
		public string[] TLD => new [] { ".gg" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "GBP" };
		public string[] CallingCodes => new [] { "44" };
	}
}
