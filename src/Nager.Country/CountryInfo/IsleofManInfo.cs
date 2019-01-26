namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Isle of Man
	/// </summary>
	public class IsleofManInfo : ICountryInfo
	{
		public string CommonName => "Isle of Man";
		public string OfficialName => "Isle of Man";

		public Alpha2Code Alpha2Code => Alpha2Code.IM;
		public Alpha3Code Alpha3Code => Alpha3Code.IMN;
		public int NumericCode => 833;
		public string[] TLD => new [] { ".im" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "GBP" };
		public string[] CallingCodes => new [] { "44" };
	}
}
