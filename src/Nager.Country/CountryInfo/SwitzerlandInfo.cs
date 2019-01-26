namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Switzerland
	/// </summary>
	public class SwitzerlandInfo : ICountryInfo
	{
		public string CommonName => "Switzerland";
		public string OfficialName => "Swiss Confederation";

		public Alpha2Code Alpha2Code => Alpha2Code.CH;
		public Alpha3Code Alpha3Code => Alpha3Code.CHE;
		public int NumericCode => 756;
		public string[] TLD => new [] { ".ch" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.WesternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.FR,
			Alpha2Code.IT,
			Alpha2Code.LI,
			Alpha2Code.DE,
		};

		public string[] Currencies => new [] { "CHE", "CHF", "CHW" };
		public string[] CallingCodes => new [] { "41" };
	}
}
