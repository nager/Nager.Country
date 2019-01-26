namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Spain
	/// </summary>
	public class SpainInfo : ICountryInfo
	{
		public string CommonName => "Spain";
		public string OfficialName => "Kingdom of Spain";

		public Alpha2Code Alpha2Code => Alpha2Code.ES;
		public Alpha3Code Alpha3Code => Alpha3Code.ESP;
		public int NumericCode => 724;
		public string[] TLD => new [] { ".es" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AD,
			Alpha2Code.FR,
			Alpha2Code.GI,
			Alpha2Code.PT,
			Alpha2Code.MA,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "34" };
	}
}
