namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Andorra
	/// </summary>
	public class AndorraInfo : ICountryInfo
	{
		public string CommonName => "Andorra";
		public string OfficialName => "Principality of Andorra";

		public Alpha2Code Alpha2Code => Alpha2Code.AD;
		public Alpha3Code Alpha3Code => Alpha3Code.AND;
		public int NumericCode => 020;
		public string[] TLD => new [] { ".ad" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.FR,
			Alpha2Code.ES,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "376" };
	}
}
