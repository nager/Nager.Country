namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Belgium
	/// </summary>
	public class BelgiumInfo : ICountryInfo
	{
		public string CommonName => "Belgium";
		public string OfficialName => "Kingdom of Belgium";

		public Alpha2Code Alpha2Code => Alpha2Code.BE;
		public Alpha3Code Alpha3Code => Alpha3Code.BEL;
		public int NumericCode => 056;
		public string[] TLD => new [] { ".be" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.WesternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.FR,
			Alpha2Code.DE,
			Alpha2Code.LU,
			Alpha2Code.NL,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "32" };
	}
}
