namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Vatican City
	/// </summary>
	public class VaticanCityInfo : ICountryInfo
	{
		public string CommonName => "Vatican City";
		public string OfficialName => "Vatican City State";

		public Alpha2Code Alpha2Code => Alpha2Code.VA;
		public Alpha3Code Alpha3Code => Alpha3Code.VAT;
		public int NumericCode => 336;
		public string[] TLD => new [] { ".va" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IT,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "3906698", "379" };
	}
}
