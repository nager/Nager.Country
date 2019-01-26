namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Italy
	/// </summary>
	public class ItalyInfo : ICountryInfo
	{
		public string CommonName => "Italy";
		public string OfficialName => "Italian Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.IT;
		public Alpha3Code Alpha3Code => Alpha3Code.ITA;
		public int NumericCode => 380;
		public string[] TLD => new [] { ".it" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.FR,
			Alpha2Code.SM,
			Alpha2Code.SI,
			Alpha2Code.CH,
			Alpha2Code.VA,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "39" };
	}
}
